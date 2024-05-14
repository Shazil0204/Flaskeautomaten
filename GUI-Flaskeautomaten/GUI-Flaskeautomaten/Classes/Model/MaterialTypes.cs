namespace GUI_Flaskeautomaten.Classes
{
	// Class to manage different material types
	internal class MaterialTypes
	{
		private List<string> _materialTypes; // List to store material types

		// Constructor to initialize the list
		internal MaterialTypes()
		{
			_materialTypes = new List<string>()
			{
				"Metal",
				"Plastic",
				"Glass"
			};
		}

		// Method to retrieve all material types
		internal List<string> GetAllMaterialTypes()
		{
			return _materialTypes;
		}
	}
}
