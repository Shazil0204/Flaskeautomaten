using GUI_Flaskeautomaten.Interfaces;

namespace GUI_Flaskeautomaten.Classes.Model.Pant_inheritance
{
	// Abstract base class representing a generic Pant item.
	abstract class Pant : IPant
	{
		#region Fields

		/// <summary>
		/// The material of the pant item (e.g., plastic, glass).
		/// </summary>
		private protected string _material = "";

		/// <summary>
		/// The type of pant (e.g., can, bottle), represented by a character.
		/// </summary>
		private protected char _pantType;

		/// <summary>
		/// The type of beverage the pant item contains (e.g., soda, beer).
		/// </summary>
		private protected string _beverageType = "";

		/// <summary>
		/// Unique serial number for the beverage
		/// </summary>
		private protected string _serialNumber = "";

		#endregion

		#region Properties

		/// <summary>
		/// Gets or sets the material of the pant item.
		/// </summary>
		public string Material
		{
			get { return _material; }
			set { _material = value; }
		}

		/// <summary>
		/// Gets the type of the pant item.
		/// </summary>
		public char PantType
		{
			get { return _pantType; }
		}

		/// <summary>
		/// Gets or sets the type of beverage the pant item contains.
		/// </summary>
		public string BeverageType
		{
			get { return _beverageType; }
			set { _beverageType = value; }
		}

		/// <summary>
		/// Gets the serial number for the beverage
		/// </summary>
		public string SerialNumber
		{
			get { return _serialNumber; }
		}

		#endregion
	}
}
