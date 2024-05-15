using GUI_Flaskeautomaten.Classes.Model.Pant_inheritance;

namespace GUI_Flaskeautomaten.Classes
{
	internal class PantA : Pant
	{
		#region Constructors

		/// <summary>
		/// Constructor to initialize a new instance of PantA with specific material and beverageType.
		/// </summary>
		/// <param name="material"></param>
		/// <param name="beverageType"></param>
		/// <param name="serialNumber"></param>
		public PantA(string material, string beverageType, string serialNumber)
		{
			this._pantType = 'A'; // 'A' denotes the type of this Pant item.
			this._material = material;
			this._beverageType = beverageType;
			this._serialNumber = serialNumber;
		}

		#endregion
	}
}
