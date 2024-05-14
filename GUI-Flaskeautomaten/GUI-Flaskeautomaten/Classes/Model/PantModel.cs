using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI_Flaskeautomaten.Classes.Model.Pant_inheritance;

namespace GUI_Flaskeautomaten.Classes
{
	internal class PantModel
	{
		#region Fields
		private List<Pant> _pantList;
		#endregion

		#region Constructors
		internal PantModel() {
			_pantList = new List<Pant>();
		}
		#endregion

		#region Methods
		internal void AddItem(Pant pantToAdd)
        {
            _pantList.Add(pantToAdd);
		}
		 
		internal List<Pant> GetTotalItems() 
		{
			return _pantList;
		}

		public List<T> GetTotalOfType<T>() where T : Pant 
		{
			return _pantList.OfType<T>().ToList();
		}
		#endregion
	}
}
