using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Flaskeautomaten.Interfaces
{
	// Interface defining properties for items with pant-related information
	internal interface IPant
	{
		#region Properties
		float PantValue { get; } // Property to get the pant value

		string Material { get; set; } // Property to get or set the material of the item

		string BeverageType { get; set; } // Property to get or set the beverage type of the item

		char PantType { get; } // Property to get the pant type of the item
		#endregion
	}
}
