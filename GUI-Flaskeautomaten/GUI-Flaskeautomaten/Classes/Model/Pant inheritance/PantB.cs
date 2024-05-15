using GUI_Flaskeautomaten.Classes.Model.Pant_inheritance;

namespace GUI_Flaskeautomaten.Classes
{
	internal class PantB : Pant
	{
		#region Constructors

		/// <summary>
		/// Constructor to initialize a new instance of PantB with specific material and beverageType.
		/// </summary>
		/// <param name="material"></param>
		/// <param name="beverageType"></param>
		/// <param name="serialNumber"></param>
		public PantB(string material, string beverageType, string serialNumber)
		{
			this._pantType = 'B'; // 'B' denotes the type of this Pant item.
			this._material = material;
			this._beverageType = beverageType;
			this._serialNumber = serialNumber;
		}

		#endregion
	}
}
