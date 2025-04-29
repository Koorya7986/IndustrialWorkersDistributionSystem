using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomProject.Models.Helpers
{
	public class DistributionModel
	{
		[DisplayName("ID оборуд.")]
		public string EquipmentId { get; set; }
		[DisplayName("ID сотрудника")]
		public string WorkerId { get; set; }
		[DisplayName("ФИО")]
		public string WorkerFullName { get; set; }
		[DisplayName("Возм. отказа")]
		public string PossibilityFailure { get; set; }
	}
}
