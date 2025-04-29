using DiplomProject.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomProject.Views
{
    public interface IMainView : IView
	{
		void SetEquipmentBindingSource(BindingSource source);
		void SetWorkersBindingSource(BindingSource source);
		void SetErrorEquipmentBindingSource(BindingSource source);
		void SetDistributionEquipmentBindingSource(BindingSource source);
		void SetDistributionWorkersBindingSource(BindingSource source);
		void SetDistributionResultBindingSource(BindingSource source);
		void ClearSelection();

		event EventHandler LoadEquipmentEvent;
		event EventHandler LoadWorkersEvent;
		event EventHandler LoadErrorsEvent;
		event EventHandler ClearErrorsListEvent;

		event EventHandler LoadDistributionEquipmentEvent;
		event EventHandler LoadDistributionWorkersEvent;
		event EventHandler<ChoiseModel> DistributeEvent;
		event EventHandler<string> SaveDistributionEvent;
		event EventHandler ResetEvent;
	}
}