namespace GUI_Flaskeautomaten.Classes
{
	// Class to manage different material types
	internal class MaterialTypes
	{
        #region Fields
		/// <summary>
		/// List to store material types
		/// </summary>
        private List<string> _materialTypes;
        #endregion

        #region Constructors
		/// <summary>
		/// Constructor to initialize the list
		/// </summary>
        internal MaterialTypes()
		{
			_materialTypes = new List<string>()
			{
				"Metal",
				"Plastic",
				"Glass"
			};
		}
		#endregion

		#region Methods
		/// <summary>
		/// Method to retrieve all material types
		/// </summary>
		/// <returns></returns>
		internal List<string> GetAllMaterials()
		{
			return _materialTypes;
		}
        #endregion
    }
}
