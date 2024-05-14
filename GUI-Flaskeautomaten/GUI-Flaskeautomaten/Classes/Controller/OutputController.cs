using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

		internal (string, string, string) WriteToScreen(object obj)
		{


			string AmountA = "";
			string AmountB = "";
			string AmountC = "";

			int countA = 0;
			int countB = 0;
			int countC = 0;


			foreach (var pant in _pantModel.GetTotalOfType<PantA>())
			{
				countA++;
				
				AmountA = countA.ToString();
			}

			foreach (var pant in _pantModel.GetTotalOfType<PantB>()) 
			{

				countB++;

				AmountB = countB.ToString();
			}

            foreach (var pant in _pantModel.GetTotalOfType<PantC>())
            {
				countC++;

				AmountC = countC.ToString();
			}
			return (AmountA, AmountB, AmountC);

        }
	}
}
