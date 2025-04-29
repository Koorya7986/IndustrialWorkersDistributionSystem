using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomProject.Models.Entities
{
    public class Equipment
    {
		[DisplayName("Идентификатор")]
		public string Id { get; set; }
        public List<Error> Errors { get; set; }
    }
}
