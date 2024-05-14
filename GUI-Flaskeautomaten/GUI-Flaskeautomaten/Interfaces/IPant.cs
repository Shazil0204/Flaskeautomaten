using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Flaskeautomaten.Interfaces
{
	internal interface IPant
	{
		#region Fields
		float PantValue { get; }

		string Material { get; set; }
		
		string BeverageType { get; set; }

		char PantType { get; }
		#endregion
	}
}
