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
			PrintToScreen(null);
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

		private void PrintToScreen(object obj)
		{
			OutputController outputController = new OutputController(_pantModel);

			ThreadPool.QueueUserWorkItem(state =>
			{
				try
				{
					var output = outputController.WriteToScreen(obj);

					// Assuming you have UI elements for displaying the counts
					Pant_A_Text.Text = $"Pant A: {output.Item1}";
					Pant_B_Text.Text = $"Pant B: {output.Item2}";
					Pant_C_Text.Text = $"Pant C: {output.Item3}";
				}
				catch (Exception ex)
				{
					// Handle the exception (e.g., log it or display an error message)
					Console.WriteLine($"Error: {ex.Message}");
				}
			});
			//while (true)
			//{

			//	string amountA = "";
			//	string amountB = "";
			//	string amountC = "";

			//	// Queue the method for execution on the ThreadPool
			//	ThreadPool.QueueUserWorkItem(state =>
			//	{
			//		// Call the WriteToScreen method
			//		var output = outputController.WriteToScreen(outputController.WriteToScreen);

			//		// Use a synchronization context to marshal the results back to the main thread
			//		SynchronizationContext.Current.Post(_ =>
			//		{
			//			// Retrieve the returned values from the method
			//			amountA = output.Item1;
			//			amountB = output.Item2;
			//			amountC = output.Item3;
			//	Pant_A_Text.Text = $"Pant A:{output.Item1}";
			//	Pant_B_Text.Text = $"Pant B:{output.Item2}";
			//	Pant_C_Text.Text = $"Pant B:{output.Item3}";

			//			// Now you can use amountA, amountB, and amountC here
			//		}, null);
			//	});

			//	Pant_C_Text.Text = $"Pant C:{amountC}";
			//}


		}
	}
}