using DiplomProject.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomProject.Views
{
	public interface IView
	{
		void Show();
		void Close();
		void ShowMessage(string message, MessageType type);
	}
}
