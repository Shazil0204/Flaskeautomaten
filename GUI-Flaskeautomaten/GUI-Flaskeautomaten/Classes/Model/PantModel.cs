using GUI_Flaskeautomaten.Classes.Model.Pant_inheritance;
using System.Collections.Concurrent;

namespace GUI_Flaskeautomaten.Classes
{
	// Class to manage items with pant-related information
	internal class PantModel
	{
		#region Fields
		/// <summary>
		/// List to store items with pant-related information
		/// </summary>
		private ConcurrentBag<Pant> _pantList;
		#endregion

		#region Constructors
		/// <summary>
		/// Initialize the list in the constructor
		/// </summary>
		internal PantModel()
		{
			_pantList = new ConcurrentBag<Pant>();
		}
		#endregion

		#region Methods
		/// <summary>
		/// Method to add a pant-related item to the list
		/// </summary>
		/// <param name="pantToAdd"></param>
		internal void AddItem(Pant pantToAdd)
		{
			_pantList.Add(pantToAdd);
		}

		/// <summary>
		/// This is going to clear all the data from the lists
		/// </summary>
		internal void RemoveItem()
		{
			_pantList.Clear();
		}

		/// <summary>
		/// Method to retrieve all items with pant-related information
		/// </summary>
		/// <returns></returns>
		internal ConcurrentBag<Pant> GetTotalItems()
		{
			return _pantList;
		}

		/// <summary>
		/// Method to retrieve all items of a specific type with pant-related information
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		internal int GetTotalOfType<T>() where T : Pant
		{
			return _pantList.OfType<T>().ToList().Count;
		}

		#endregion
	}
}
