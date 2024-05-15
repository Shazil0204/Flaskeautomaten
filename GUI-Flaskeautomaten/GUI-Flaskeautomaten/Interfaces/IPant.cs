using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Flaskeautomaten.Interfaces
{
	/// <summary>
	/// Interface defining properties for items with pant-related information
	/// </summary>
	internal interface IPant
	{
		#region Properties
		/// <summary>
		/// Property to get or set the material of the item
		/// </summary>
		string Material { get; set; } 

		/// <summary>
		/// Property to get or set the beverage type of the item
		/// </summary>
		string BeverageType { get; set; } 

		/// <summary>
		/// Property to get the pant type of the item
		/// </summary>
		char PantType { get; } 

		string SerialNumber { get; }
		#endregion
	}
}
