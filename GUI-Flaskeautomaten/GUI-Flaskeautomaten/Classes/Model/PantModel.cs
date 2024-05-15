using GUI_Flaskeautomaten.Classes.Model.Pant_inheritance;
using System.Collections.Concurrent;

namespace GUI_Flaskeautomaten.Classes
{
	// Class to manage items with pant-related information
	internal class PantModel
	{
		#region Fields
		private ConcurrentBag<Pant> _pantList; // List to store items with pant-related information
		#endregion

		#region Constructors
		internal PantModel()
		{
			_pantList = new ConcurrentBag<Pant>(); // Initialize the list in the constructor
		}
		#endregion

		#region Methods
		// Method to add a pant-related item to the list
		internal void AddItem(Pant pantToAdd)
		{
			_pantList.Add(pantToAdd);
		}

		// Method to retrieve all items with pant-related information
		internal ConcurrentBag<Pant> GetTotalItems()
		{
			return _pantList;
		}

		// Method to retrieve all items of a specific type with pant-related information
		internal int GetTotalOfType<T>() where T : Pant
		{
			return _pantList.OfType<T>().ToList().Count;
		}


		#endregion
	}
}
