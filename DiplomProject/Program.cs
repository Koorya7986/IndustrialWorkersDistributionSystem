using DiplomProject.Models.Helpers;
using DiplomProject.Models.Repositories;
using DiplomProject.Presenters;
using DiplomProject.Views;
using System.Configuration;

namespace DiplomProject
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();

			string connectionString = ConfigurationManager.ConnectionStrings["DistSystemDatabase"].ConnectionString;
			EquipmentRepository equipmentRepository = new EquipmentRepository(connectionString);
			WorkerRepository workerRepository = new WorkerRepository(connectionString);

			FuzzyDistributionSystem fuzzyDistributionSystem = new FuzzyDistributionSystem();
			DocumentCreator documentCreator = new DocumentCreator();

			IMainView view = new DistributionSystemMainForm();
			new MainPresenter(view, equipmentRepository, workerRepository, fuzzyDistributionSystem, documentCreator);
			Application.Run((Form)view);
		}
	}
}