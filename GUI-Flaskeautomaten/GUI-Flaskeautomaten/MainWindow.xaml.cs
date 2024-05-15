using GUI_Flaskeautomaten.Classes;
using System.Printing;
using System.Windows;
using System.Windows.Controls;

namespace GUI_Flaskeautomaten
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		#region Fields
		/// <summary>
		/// PantModel instance to manage pant objects
		/// </summary>
		private readonly PantModel _pantModel = new PantModel();
		#endregion

		#region Constructors

		public MainWindow()
		{
			InitializeComponent();
		}
		#endregion

		#region Methods
		/// <summary>
		/// Event handler for pant buttons
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void PantButtonClick(object sender, RoutedEventArgs e)
		{
			Button clickedButton = (Button)sender;
			if (clickedButton != null)
			{
				DoneMessage.Visibility = Visibility.Collapsed;

				InputController inputController = new InputController(_pantModel);

				// Get random material, beverage, and calculate serial number
				string material = inputController.GetRandomValueFromList(new MaterialTypes().GetAllMaterials());
				string beverage = inputController.GetRandomValueFromList(new BeverageTypes().GetAllBeverages());
				string serialNumber = inputController.CalculateSerialNumber();

				string buttonTag = clickedButton.Tag.ToString() ?? "";
				switch (buttonTag)
				{
					case "PantA":
						PantA pantA = new PantA(material, beverage, serialNumber);
						await Task.Run(() => inputController.AddPant(pantA));
						break;
					case "PantB":
						PantB pantB = new PantB(material, beverage, serialNumber);
						await Task.Run(() => inputController.AddPant(pantB));
						break;
					case "PantC":
						PantC pantC = new PantC(material, beverage, serialNumber);
						await Task.Run(() => inputController.AddPant(pantC));
						break;
					default:
						break;
				}


				// Update screen display
				PrintToScreen();
			}
		}

		/// <summary>
		/// Event handler for "Done" button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void DoneButtonClick(object sender, RoutedEventArgs e)
		{
			// Instantiate output controller and write receipt in a separate thread
			OutputController outputController = new OutputController(_pantModel);

			// Create a CountdownEvent with an initial count of 1
			CountdownEvent countdown = new CountdownEvent(1);

			// Queue the work item
			ThreadPool.QueueUserWorkItem(state =>
			{
				try
				{
					outputController.WriteReceipt(sender);
				}
				finally
				{
					// Signal that the work item is completed
					countdown.Signal();
				}
			});

			// Wait for the work item to complete
			countdown.Wait();

			// Now execute ClearScreen
			ClearScreen();
		}


		/// <summary>
		/// Update screen display with pant totals and total price
		/// </summary>
		private void PrintToScreen()
		{
			OutputController outputController = new OutputController(_pantModel);

			// Calculate total price
			float totalPrice = outputController.CalculateTotalPrice();

			// Update text boxes with pant totals and total price
			Pant_A_Text.Text = _pantModel.GetTotalOfType<PantA>().ToString();
			Pant_B_Text.Text = _pantModel.GetTotalOfType<PantB>().ToString();
			Pant_C_Text.Text = _pantModel.GetTotalOfType<PantC>().ToString();
			Total_Text.Text = $"{totalPrice} DKK";
		}

		/// <summary>
		/// This is going to remove all the data that user have inserted in the application when user click Done btn
		/// </summary>
		private void ClearScreen()
		{
			// Update text boxes with pant totals and total price
			InputController IC = new InputController(_pantModel);

			IC.RemovePant();

			DoneMessage.Visibility = Visibility.Visible;

			Pant_A_Text.Text = "x0";
			Pant_B_Text.Text = "x0";
			Pant_C_Text.Text = "x0";
			Total_Text.Text = "DKK";
		}
		#endregion
	}
}