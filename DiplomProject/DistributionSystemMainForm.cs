using DiplomProject.Models.Helpers;
using DiplomProject.Views;

namespace DiplomProject
{
	public partial class DistributionSystemMainForm : Form, IMainView
	{
		public DistributionSystemMainForm()
		{
			InitializeComponent();

			this.Load += delegate
			{
				LoadEquipmentEvent?.Invoke(this, EventArgs.Empty);
				LoadWorkersEvent?.Invoke(this, EventArgs.Empty);

				LoadDistributionEquipmentEvent?.Invoke(this, EventArgs.Empty);
				LoadDistributionWorkersEvent?.Invoke(this, EventArgs.Empty);
			};

			button_update_equipment.Click += delegate
			{
				LoadEquipmentEvent?.Invoke(this, EventArgs.Empty);
			};

			button_update_workers.Click += delegate
			{
				LoadWorkersEvent?.Invoke(this, EventArgs.Empty);
			};

			button_distribute.Click += delegate
			{
				DistributeEvent?.Invoke(this, new ChoiseModel
				{
					EquipmentsID = listBox_equipment.SelectedItems.Cast<string>().ToList(),
					WorkersID = listBox_workers.SelectedItems.Cast<string>().Select(w => w.Split('|')[0].Trim()).ToList(),
				});
			};

			button_save.Click += delegate
			{
				SaveDistributionEvent?.Invoke(this, tabPage3.Controls.OfType<RadioButton>().First(x => x.Checked).Name);
			};

			button_reset.Click += delegate
			{
				ResetEvent?.Invoke(this, EventArgs.Empty);
			};
		}

		public event EventHandler LoadEquipmentEvent;
		public event EventHandler LoadWorkersEvent;
		public event EventHandler LoadErrorsEvent;
		public event EventHandler ClearErrorsListEvent;
		public event EventHandler ResetEvent;

		public event EventHandler LoadDistributionEquipmentEvent;
		public event EventHandler LoadDistributionWorkersEvent;
		public event EventHandler<ChoiseModel> DistributeEvent;
		public event EventHandler<string> SaveDistributionEvent;

		public void ClearSelection()
		{
			listBox_equipment.ClearSelected();
			listBox_workers.ClearSelected();
		}

		public void SetEquipmentBindingSource(BindingSource source)
		{
			dataGridView_equipment.DataSource = source;
		}

		public void SetWorkersBindingSource(BindingSource source)
		{
			dataGridView_workers.DataSource = source;
		}

		public void SetErrorEquipmentBindingSource(BindingSource source)
		{
			dataGridView_errors.DataSource = source;
		}

		public void SetDistributionEquipmentBindingSource(BindingSource source)
		{
			listBox_equipment.DataSource = source;
		}

		public void SetDistributionWorkersBindingSource(BindingSource source)
		{
			listBox_workers.DataSource = source;
		}

		public void SetDistributionResultBindingSource(BindingSource source)
		{
			dataGridView_results.DataSource = source;
		}

		public void ShowMessage(string message, MessageType type)
		{
			MessageBoxIcon icon = type == MessageType.Error ? MessageBoxIcon.Error : MessageBoxIcon.Information;
			MessageBox.Show(message, "Œ¯Ë·Í‡", MessageBoxButtons.OK, icon);
		}

		private void dataGridView_equipment_CurrentCellChanged(object sender, EventArgs e)
		{
			ClearErrorsListEvent?.Invoke(this, EventArgs.Empty);
			LoadErrorsEvent?.Invoke(this, EventArgs.Empty);
		}
	}
}
