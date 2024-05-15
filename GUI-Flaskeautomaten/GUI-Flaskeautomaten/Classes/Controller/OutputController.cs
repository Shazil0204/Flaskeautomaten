using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace GUI_Flaskeautomaten.Classes
{
    internal class OutputController
    {
		#region Fields
		private PantModel _pantModel;

		internal OutputController(PantModel pantModel)
		{
			this._pantModel = pantModel;
		}

		// Path for reciept destination
		string path = "path.example.txt";
        #endregion

        internal void WriteReceipt(object obj)
        {
			using (StreamWriter sw = new StreamWriter(path))
			{
				foreach (var item in _pantModel.GetTotalItems())
				{
					sw.WriteLine(item);
				}
			}
		}

		internal string[] WriteToScreen()
		{
			string totalPantA = _pantModel.GetTotalOfType<PantA>().Count.ToString();
			string totalPantB = _pantModel.GetTotalOfType<PantB>().Count.ToString();
			string totalPantC = _pantModel.GetTotalOfType<PantC>().Count.ToString();

			string[] Manike = [totalPantA, totalPantB, totalPantC];

			return Manike;

        }
	}
}
