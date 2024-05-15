using System;
using System.Windows;

namespace GUI_Flaskeautomaten.Classes.Model
{
	// Class to manage pant values based on pant types
	internal class PantValues
	{
		private readonly Dictionary<char, float> _pantTypeToValue; // Dictionary to map pant types to their values

		// Constructor to initialize the dictionary with pant types and values
		internal PantValues()
		{
			_pantTypeToValue = new Dictionary<char, float>
			{
				{ 'A', 1 },
				{ 'B', 1.5f },
				{ 'C', 3 }
			};
		}

		// Method to get the pant value based on the pant type
		internal float GetPantValue(char pantType)
		{
			try
			{
				if (_pantTypeToValue.TryGetValue(pantType, out float value))
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
