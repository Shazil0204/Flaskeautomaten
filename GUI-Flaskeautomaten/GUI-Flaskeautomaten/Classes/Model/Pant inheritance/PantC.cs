using GUI_Flaskeautomaten.Classes.Model.Pant_inheritance;

namespace GUI_Flaskeautomaten.Classes
{
    internal class PantC : Pant
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
		/// <summary>
		/// Constructor to initialize a new instance of PantC with specific material and beverageType.
		/// </summary>
		/// <param name="material"></param>
		/// <param name="beverageType"></param>
		public PantC(string material, string beverageType)
		{
			this._pantType = 'C';
			this._material = material;
            this._beverageType = beverageType;
		}
        #endregion
    }

}
