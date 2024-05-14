using GUI_Flaskeautomaten.Classes.Model.Pant_inheritance;

namespace GUI_Flaskeautomaten.Classes
{
	internal class PantB : Pant
	{
		#region Fields

		private protected string _material;

		private protected char _pantType;

		private protected string _beverageType;

		#endregion

		#region Properties

		private protected string Material
		{
			get { return _material; }
			set { _material = value; }
		}

		private protected char PantType
		{
			get { return _pantType; }
		}

		#endregion Properties

		#region Constructors

		// Constructor to initialize a new instance of PantB with specific material and beverageType.
		public PantB(string material, string beverageType)
		{
			this._material = material;
			this._pantType = 'B'; // 'B' denotes the type of this Pant item.
			this._beverageType = beverageType;
		}

		#endregion
	}
}