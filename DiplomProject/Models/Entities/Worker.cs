using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomProject.Models.Entities
{
    public class Worker
    {
        [DisplayName("Идентификатор")]
        public string Id { get; set; }
        [DisplayName("ФИО")]
        public string FullName { get; set; }
		[DisplayName("Телефон")]
		public string Phone { get; set; }
		[DisplayName("Опыт работы")]
		public string Experience { get; set; }

		public override string ToString()
		{
			return $"{Id} | {FullName} | {Experience}";
		}
	}
}