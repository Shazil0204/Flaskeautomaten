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
            Random random = new Random();

            int randomValue = random.Next(options.Count);
            return options[randomValue]; 
		}

        #endregion
    }
}
