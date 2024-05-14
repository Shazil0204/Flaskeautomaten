using GUI_Flaskeautomaten.Classes.Model.Pant_inheritance;

namespace GUI_Flaskeautomaten.Classes
{
	internal class PantA : Pant
	{
		#region Constructors

		// Constructor to initialize a new instance of PantA with specific material and beverageType.
		public PantA(string material, string beverageType)
		{
			this._pantType = 'A'; // 'A' denotes the type of this Pant item.
			this._material = material;
			this._beverageType = beverageType;
		}

		#endregion
	}
}
