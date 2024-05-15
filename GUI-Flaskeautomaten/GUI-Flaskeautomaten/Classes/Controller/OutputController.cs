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
        #endregion
        #region Constructors
        internal OutputController(PantModel pantModel)
		{
			this._pantModel = pantModel;
		}
        #endregion

        #region Methods
		/// <summary>
		/// This will create a File for use like a receipt where you can see all the items user have insert into the machines
		/// </summary>
		/// <param name="obj"></param>
        internal void WriteReceipt(object obj)
        {
			// Path for reciept destination
			string directory = Environment.CurrentDirectory;
			string path = $"{directory}/example.txt";
			using (StreamWriter sw = new StreamWriter(path))
			{
				foreach (var item in _pantModel.GetTotalItems())
				{
					
					sw.WriteLine($"{item.SerialNumber} {item.PantType} {item.Material} {new PantValues().GetPantValue(item.PantType)}");
				}

				sw.WriteLine($"Total price: \n{CalculateTotalPrice()}");
			}
		}

		/// <summary>
		/// This method is to calculate the total amount by calculating all the basic information 
		/// </summary>
		/// <returns></returns>
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
        #endregion
    }
}
