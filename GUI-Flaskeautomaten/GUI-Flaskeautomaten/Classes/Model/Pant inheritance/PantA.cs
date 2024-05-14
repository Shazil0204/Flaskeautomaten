using GUI_Flaskeautomaten.Classes.Model.Pant_inheritance;

namespace GUI_Flaskeautomaten.Classes
{
	internal class PantA : Pant
	{
		#region Fields

		// The material of the PantA item.
		private protected string _material = "";

		// The type of the PantA item.
		private protected char _pantType;

		// The type of beverage the PantA item contains.
		private protected string _beverageType;

		#endregion

		#region Properties

		// Gets or sets the material of the PantA item.
		private protected string Material
		{
			get { return _material; }
			set { _material = value; }
		}

		// Gets the type of the PantA item.
		private protected char PantType
		{
			get { return _pantType; }
		}

		#endregion Properties

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
