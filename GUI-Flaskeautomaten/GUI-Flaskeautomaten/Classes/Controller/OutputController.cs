using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using GUI_Flaskeautomaten.Classes.Model;

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
		static string directory = Environment.CurrentDirectory;
		string path = $"{directory}/example.txt";
        #endregion

        internal void WriteReceipt(object obj)
        {
			using (StreamWriter sw = new StreamWriter(path))
			{
				foreach (var item in _pantModel.GetTotalItems())
				{
					
					sw.WriteLine($"{item.SerialNumber} {item.PantType} {item.Material} {new PantValues().GetPantValue(item.PantType)}");
				}

				sw.WriteLine($"Total price: \n{CalculateTotalPrice()}");
			}
		}

		internal void WriteToScreen()
		{
			while(true)
			{
				string totalPantA = _pantModel.GetTotalOfType<PantA>().ToString();
				string totalPantB = _pantModel.GetTotalOfType<PantB>().ToString();
				string totalPantC = _pantModel.GetTotalOfType<PantC>().ToString();
			}
        }

		internal float CalculateTotalPrice()
		{
			float PantAValue = new PantValues().GetPantValue('A');
			float PantBValue = new PantValues().GetPantValue('B');
			float PantCValue = new PantValues().GetPantValue('C');

			float TotalAValue = _pantModel.GetTotalOfType<PantA>() * PantAValue;
			float TotalBValue = _pantModel.GetTotalOfType<PantB>() * PantBValue;
			float TotalCValue = _pantModel.GetTotalOfType<PantC>() * PantCValue;

			float TotalPrice = TotalAValue + TotalBValue + TotalCValue;
			return TotalPrice;
		}
	}
}
