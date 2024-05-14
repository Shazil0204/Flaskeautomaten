using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GUI_Flaskeautomaten.Classes.Model
{
	internal class PantValues
	{
		private readonly Dictionary<char, int> _pantTypeToValue;

		internal PantValues()
		{
			_pantTypeToValue = new Dictionary<char, int>
			{
				{ 'A', 1 },
				{ 'B', 2 },
				{ 'C', 3 }
			};
		}

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
				MessageBox.Show($"Error: {ex.Message}"); ;
				throw;
			}
		}

	}
}
