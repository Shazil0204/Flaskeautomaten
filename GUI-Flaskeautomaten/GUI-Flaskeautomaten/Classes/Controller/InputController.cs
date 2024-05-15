using GUI_Flaskeautomaten.Classes.Model;
using GUI_Flaskeautomaten.Classes.Model.Pant_inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Flaskeautomaten.Classes
{
    internal class InputController
    {
        private PantModel _pantModel;
        Random random = new Random();

        internal InputController(PantModel pantModel)
        {
            this._pantModel = pantModel;
        }

        #region Methods
        /// <summary>
        /// Adding pant
        /// </summary>
        /// <param name="pant"></param>
        internal void AddPant(Pant pant)
        {
            _pantModel.AddItem(pant);
        }

        internal string GetRandomValueFromList(List<string> options)
        {
            int randomValue = random.Next(options.Count);
            return options[randomValue]; 
		}

        internal string CalculateSerialNumber()
        {
            int year = random.Next(23, 25);
            string month = random.Next(1, 13).ToString();
            int number = random.Next(100000, 1000000);

            if (month.Length < 2)
            {
                month = $"0{month}";
            }

            return $"{year}{month}-{number}";
        }

        #endregion
    }
}
