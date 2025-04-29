using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DiplomProject.Models.Entities
{
    public class Error
    {
		[DisplayName("Серьёзность")]
		public string Severity { get; set; }
		[DisplayName("Код ошибки")]
		public string Code { get; set; }
		[DisplayName("Описание")]
		public string Description { get; set; }
		[DisplayName("Дата и время")]
		public DateTime Date { get; set; }
	}
}
