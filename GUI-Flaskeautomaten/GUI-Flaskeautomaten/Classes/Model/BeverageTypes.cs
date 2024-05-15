namespace GUI_Flaskeautomaten.Classes
{
	// Class to manage different beverage types
	internal class BeverageTypes
	{
		#region Fields
		/// <summary>
		/// List to store beverage types
		/// </summary>
		private List<string> _beverageTypes;
		#endregion

		#region Constructors
		/// <summary>
		/// Constructor to initialize the list
		/// </summary>
		internal BeverageTypes()
		{
			_beverageTypes = new List<string>()
			{
				"Beer",
				"Soda",
				"Water"
			};
		}
		#endregion

		#region Methods
		/// <summary>
		/// Method to retrieve all beverage types
		/// </summary>
		/// <returns></returns>
		internal List<string> GetAllBeverages()
		{
			return _beverageTypes;
		}
        #endregion
    }
}
