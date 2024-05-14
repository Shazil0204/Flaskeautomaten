using GUI_Flaskeautomaten.Classes.Model.Pant_inheritance;

namespace GUI_Flaskeautomaten.Classes
{
	internal class PantB : Pant
	{
		#region Constructors

		// Constructor to initialize a new instance of PantB with specific material and beverageType.
		public PantB(string material, string beverageType)
		{
			this._pantType = 'B'; // 'B' denotes the type of this Pant item.
			this._material = material;
			this._beverageType = beverageType;
		}

		#endregion
	}
}
