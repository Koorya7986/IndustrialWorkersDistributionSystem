using DiplomProject.Models.Entities;
using DiplomProject.Models.Helpers;
using DiplomProject.Models.Repositories;
using DiplomProject.Views;
using System.Configuration;

namespace DiplomProject.Presenters
{
    public class MainPresenter
	{
		private readonly IMainView _view;
		private readonly EquipmentRepository _equipmentRepository;
		private readonly WorkerRepository _workerRepository;
		private readonly FuzzyDistributionSystem _fuzzyDistributionSystem;
		private readonly DocumentCreator _documentCreator;

		private BindingSource _equipmentBindingSource;
		private BindingSource _workerBindingSource;
		private BindingSource _errorBindingSource;

		private BindingSource _distEquipmentBindingSource;
		private BindingSource _distWorkerBindingSource;
		private BindingSource _distResultBindingSource;

		private IEnumerable<Worker> _workers;
		private IEnumerable<Equipment> _equipment;
		private List<DistributionModel> _distribution;

        public MainPresenter(IMainView view, EquipmentRepository equipmentRepository,
			WorkerRepository workerRepository, FuzzyDistributionSystem fuzzyDistributionSystem, DocumentCreator documentCreator)
        {
			_equipmentBindingSource = new BindingSource();
			_workerBindingSource = new BindingSource();
			_errorBindingSource = new BindingSource();
			_distEquipmentBindingSource = new BindingSource();
			_distWorkerBindingSource = new BindingSource();
			_distResultBindingSource = new BindingSource();

			_workers = new List<Worker>();
			_equipment = new List<Equipment>();

			_view = view;
			_equipmentRepository = equipmentRepository;
			_workerRepository = workerRepository;
			_fuzzyDistributionSystem = fuzzyDistributionSystem;
			_documentCreator = documentCreator;

			_view.LoadEquipmentEvent += async (s, e) =>
			{
				try
				{
					await LoadEquipment(s, e);
				}
				catch (Exception ex)
				{
					_view.ShowMessage(ex.Message, MessageType.Error);
				}
			};
			_view.LoadWorkersEvent += async (s, e) =>
			{
				try
				{
					await LoadWorkers(s, e);
				}
				catch (Exception ex)
				{
					_view.ShowMessage(ex.Message, MessageType.Error);
				}
			};
			_view.LoadDistributionEquipmentEvent += async (s, e) =>
			{
				try
				{
					await LoadDistEquipment(s, e);
				}
				catch (Exception ex)
				{
					_view.ShowMessage(ex.Message, MessageType.Error);
				}
			};
			_view.LoadDistributionWorkersEvent += async (s, e) =>
			{
				try
				{
					await LoadDistWorkers(s, e);
				}
				catch (Exception ex)
				{
					_view.ShowMessage(ex.Message, MessageType.Error);
				}
			};
			_view.SaveDistributionEvent += async (s, e) =>
			{
				try
				{
					await Save(e);
				}
				catch (Exception ex)
				{
					_view.ShowMessage(ex.Message, MessageType.Error);
				}
			};

			_view.LoadErrorsEvent += LoadErrors;
			_view.ClearErrorsListEvent += ClearErrors;
			_view.DistributeEvent += Distribute;
			_view.ResetEvent += Reset;

			_view.SetEquipmentBindingSource(_equipmentBindingSource);
			_view.SetWorkersBindingSource(_workerBindingSource);
			_view.SetErrorEquipmentBindingSource(_errorBindingSource);
			_view.SetDistributionEquipmentBindingSource(_distEquipmentBindingSource);
			_view.SetDistributionWorkersBindingSource(_distWorkerBindingSource);
			_view.SetDistributionResultBindingSource(_distResultBindingSource);
        }

		private void Reset(object? sender, EventArgs e)
		{
			_distResultBindingSource = null;
			_distribution = null;
			_view.ClearSelection();
		}

		private async Task LoadDistWorkers(object? sender, EventArgs e)
		{
			_workers = await _workerRepository.GetAll();
			_distWorkerBindingSource.DataSource = _workers.Select(w => w.ToString());
		}

		private async Task LoadDistEquipment(object? sender, EventArgs e)
		{
			_equipment = await _equipmentRepository.GetAll();
			_distEquipmentBindingSource.DataSource = _equipment.Select(eq => eq.Id);
		}

		private void Distribute(object? sender, ChoiseModel e)
		{
			if (e.EquipmentsID.Count < 5 || e.WorkersID.Count < 5)
			{
				_view.ShowMessage("Минимально количество выюбранного оборудования или рабочего состава - 5", MessageType.Error);
				return;
			}

			if (e.EquipmentsID.Count != e.WorkersID.Count)
			{
				_view.ShowMessage("Необходимо выбрать одинаковое количество станков и рабочих", MessageType.Error);
				return;
			}

			List<Equipment> chosenEquipment = new List<Equipment>();
			List<Worker> chosenWorkers = new List<Worker>();

            foreach (var eqID in e.EquipmentsID)
            {
				Equipment eq = _equipment.FirstOrDefault(x => x.Id == eqID)!;
				chosenEquipment.Add(eq);
            }

			foreach (var wID in e.WorkersID)
			{
				Worker w = _workers.FirstOrDefault(x => x.Id == wID)!;
				chosenWorkers.Add(w);
			}

			List<EquipmentPossibilityFailureModel> possibilities = null;

			try
			{
				possibilities = _fuzzyDistributionSystem.CreateEquipmentPossibilityFailureList(chosenEquipment);
			}
			catch (Exception ex)
			{
				_view.ShowMessage(ex.Message, MessageType.Error);
			}

			possibilities = possibilities!.OrderByDescending(r => r.Possibility).ToList();
			chosenWorkers = chosenWorkers.OrderByDescending(cw => double.Parse(cw.Experience)).ToList();

			_distribution = new List<DistributionModel>();

            for (int i = 0; i < possibilities.Count; i++)
            {
				_distribution.Add(new DistributionModel
				{
					EquipmentId = possibilities[i].Id,
					WorkerId = chosenWorkers[i].Id,
					WorkerFullName = chosenWorkers[i].FullName,
					PossibilityFailure = possibilities[i].Possibility.ToString("0.##")
				});
            }

			_distResultBindingSource.DataSource = _distribution;
        }

		private void ClearErrors(object? sender, EventArgs e)
		{
			_errorBindingSource.DataSource = null;
		}

		private void LoadErrors(object? sender, EventArgs e)
		{
			Equipment? equipment = (Equipment)_equipmentBindingSource.Current;
			_errorBindingSource.DataSource = _equipment.FirstOrDefault(eq => eq.Id == equipment.Id)!.Errors;
		}

		private async Task LoadWorkers(object? sender, EventArgs e)
		{
			_workers = await _workerRepository.GetAll();
			_workerBindingSource.DataSource = _workers;
		}

		private async Task LoadEquipment(object? sender, EventArgs e)
		{
			_equipment = await _equipmentRepository.GetAll();
			_equipmentBindingSource.DataSource = _equipment;
			_errorBindingSource.DataSource = null;
		}

		private async Task Save(string extensionName)
		{
			if (_distribution is null || _distribution.Count == 0)
			{
				_view.ShowMessage("Не удалось сохранить: план распределения ещё не создан", MessageType.Error);
				return;
			}

			if (extensionName.Contains("word"))
				await SaveAsWordFile();
			else
				await SaveAsTxtFile();
		}

		private async Task SaveAsWordFile()
		{
			string file = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			await Task.Run(() => _documentCreator.CreateWordFile(_distribution, file));
		}

		private async Task SaveAsTxtFile()
		{
			string file = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			await _documentCreator.CreateTxtFile(_distribution, file);
		}
	}
}
