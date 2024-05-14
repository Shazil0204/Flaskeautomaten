using GUI_Flaskeautomaten.Interfaces;

namespace GUI_Flaskeautomaten.Classes.Model.Pant_inheritance
{
	// Abstract base class representing a generic Pant item.
	abstract class Pant : IPant
	{
		#region Fields

		// The value of the pant (deposit).
		private protected float _pantValue;

		// The material of the pant item (e.g., plastic, glass).
		private protected string _material = "";

		// The type of pant (e.g., can, bottle), represented by a character.
		private protected char _pantType;

		// The type of beverage the pant item contains (e.g., soda, beer).
		private protected string _beverageType = "";

		#endregion

		#region IPant Implementation

		// Gets the value of the pant.
		public float PantValue
		{
			get { return _pantValue; }
		}

		// Gets or sets the material of the pant item.
		public string Material
		{
			get { return _material; }
			set { _material = value; }
		}

		// Gets the type of the pant item.
		public char PantType
		{
			get { return _pantType; }
		}

		// Gets or sets the type of beverage the pant item contains.
		public string BeverageType
		{
			get { return _beverageType; }
			set { _beverageType = value; }
		}

		#endregion
	}
}
