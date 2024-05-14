using System;
using System.Windows;

namespace GUI_Flaskeautomaten.Classes.Model
{
	// Class to manage pant values based on pant types
	internal class PantValues
	{
		private readonly Dictionary<char, int> _pantTypeToValue; // Dictionary to map pant types to their values

		// Constructor to initialize the dictionary with pant types and values
		internal PantValues()
		{
			_pantTypeToValue = new Dictionary<char, int>
			{
				{ 'A', 1 },
				{ 'B', 2 },
				{ 'C', 3 }
			};
		}

		// Method to get the pant value based on the pant type
		internal int GetPantValue(char pantType)
		{
			try
			{
				if (_pantTypeToValue.TryGetValue(pantType, out int value))
				{
					return value;
				}
				else
				{
					throw new ArgumentException($"Invalid pantType: {pantType}");
				}
			}
			catch (ArgumentException ex)
			{
				MessageBox.Show($"Error: {ex.Message}"); // Display error message if pant type is invalid
				throw;
			}
		}

	}
}
