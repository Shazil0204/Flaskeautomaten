namespace GUI_Flaskeautomaten.Classes
{
	// Class to manage different beverage types
	internal class BeverageTypes
	{
		private List<string> _beverageTypes; // List to store beverage types

		// Constructor to initialize the list
		internal BeverageTypes()
		{
			_beverageTypes = new List<string>()
			{
				"Beer",
				"Soda",
				"Water"
			};
		}

		// Method to retrieve all beverage types
		internal List<string> GetAllBeverages()
		{
			return _beverageTypes;
		}
	}
}
