namespace GUI_Flaskeautomaten.Classes
{
	internal class MaterialTypes
	{
		private List<string> _materialTypes;

		internal MaterialTypes()
		{
			_materialTypes = new List<string>();
		}

		internal List<string> GetAllMaterialTypes ()
		{
			return _materialTypes;
		}
	}
}
