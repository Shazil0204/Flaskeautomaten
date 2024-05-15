using GUI_Flaskeautomaten.Classes;
using GUI_Flaskeautomaten.Classes.Model.Pant_inheritance;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace GUI_Flaskeautomaten
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly PantModel _pantModel = new PantModel();

		public MainWindow()
		{
			InitializeComponent();
		}

		private void PantButtonClick(object sender, RoutedEventArgs e)
		{
			Button clickedButton = (Button)sender;
			if (clickedButton != null)
			{
				InputController inputController = new InputController(_pantModel);

				string material = inputController.GetRandomValueFromList(new MaterialTypes().GetAllMaterialTypes());
				string beverage = inputController.GetRandomValueFromList(new BeverageTypes().GetAllBeverages());

				string buttonTag = clickedButton.Tag.ToString() ?? "";
				switch (buttonTag)
				{
					case "PantA":
						PantA pantA = new PantA(material, beverage);
						ThreadPool.QueueUserWorkItem(state => inputController.AddPant((Pant)state), pantA);
						break;
					case "PantB":
						PantB pantB = new PantB(material, beverage);
						ThreadPool.QueueUserWorkItem(state => inputController.AddPant((Pant)state), pantB);
						break;
					case "PantC":
						PantC pantC = new PantC(material, beverage);
						ThreadPool.QueueUserWorkItem(state => inputController.AddPant((Pant)state), pantC);
						break;
					default:
						break;
				}
			}
		}

		private void DoneButtonClick(object sender, RoutedEventArgs e)
		{
			OutputController outputController = new OutputController(_pantModel);
			ThreadPool.QueueUserWorkItem(outputController.WriteReceipt);
		}

		private void PrintToScreen()
		{
			OutputController outputController = new OutputController(_pantModel);

			ThreadPool.QueueUserWorkItem(state =>
			{
				try
				{
					var output = outputController.WriteToScreen();

					// Use Dispatcher.Invoke to update the UI elements on the UI thread
					Dispatcher.Invoke(() =>
					{
						Pant_A_Text.Text = $"Pant A: {output[0]}";
						Pant_B_Text.Text = $"Pant B: {output[1]}";
						Pant_C_Text.Text = $"Pant C: {output[2]}";
					});
				}
				catch (Exception ex)
				{
					// Handle the exception (e.g., log it or display an error message)
					Console.WriteLine($"Error: {ex.Message}");
					MessageBox.Show($"Error: {ex.Message}");
				}
			});
		}
	}
}