namespace GUI_Flaskeautomaten.Classes
{
	internal class BeverageTypes
	{
		private List<string> _beverageTypes;

		internal BeverageTypes()
		{
			_beverageTypes = new List<string>();
		}

		internal List<string> GetAllBeverages()
		{
			return _beverageTypes;
		}
	}
}
