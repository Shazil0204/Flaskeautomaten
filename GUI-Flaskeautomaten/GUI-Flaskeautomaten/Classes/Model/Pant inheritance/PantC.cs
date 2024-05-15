
using GUI_Flaskeautomaten.Classes.Model.Pant_inheritance;

namespace GUI_Flaskeautomaten.Classes
{
	internal class PantC : Pant
	{
		#region Constructors

		// Constructor to initialize a new instance of PantC with specific material and beverageType.
		public PantC(string material, string beverageType, string serialNumber)
		{
			this._pantType = 'C'; // 'C' denotes the type of this Pant item.
			this._material = material;
			this._beverageType = beverageType;
			this._serialNumber = serialNumber;
		}

		#endregion
	}
}
