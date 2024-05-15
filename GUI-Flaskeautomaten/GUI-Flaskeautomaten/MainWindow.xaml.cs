using GUI_Flaskeautomaten.Classes;
using GUI_Flaskeautomaten.Classes.Model.Pant_inheritance;
using System.Threading;
using GUI_Flaskeautomaten.Classes.Model;
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

		private async void PantButtonClick(object sender, RoutedEventArgs e)
		{
			Button clickedButton = (Button)sender;
			if (clickedButton != null)
			{
				InputController inputController = new InputController(_pantModel);

				string material = inputController.GetRandomValueFromList(new MaterialTypes().GetAllMaterialTypes());
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

				PrintToScreen();
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

			float totalPrice = outputController.CalculateTotalPrice();

			Pant_A_Text.Text = _pantModel.GetTotalOfType<PantA>().ToString();
			Pant_B_Text.Text = _pantModel.GetTotalOfType<PantB>().ToString();
			Pant_C_Text.Text = _pantModel.GetTotalOfType<PantC>().ToString();

			Total_Text.Text = $"{totalPrice} DKK";
		}
	}
}