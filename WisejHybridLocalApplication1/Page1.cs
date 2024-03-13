using Wisej.Web;
using Wisej.Hybrid;
using System.Drawing;

namespace WisejHybridLocalApplication1
{
	public partial class Page1 : Page
	{
		// dimension of game canvas
		private const int NUMBER_OF_FIELDS_X = 40;
		private const int NUMBER_OF_FIELDS_Y = 30;

		//length/width of one "square" of the canvas
		private const int FIELD_DIMENSION = 16;

		//length of game tick in milliseconds
		private const int SPEED = 180;

		public Page1()
		{
			InitializeComponent();

			// set the game canvas to a size specified by the constants above
			GameCanvas.Size = new Size(NUMBER_OF_FIELDS_X * FIELD_DIMENSION, NUMBER_OF_FIELDS_Y * FIELD_DIMENSION);

			//game ticks happen every 100 ms (.1 sec)
			Ticker.Interval = SPEED;

			//start the ticker
			Ticker.Enabled = true;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if (Device.Valid)
			{
				Device.Popups.DisplayAlert("Congrats", "You Win");
			}
			else
			{
				AlertBox.Show("You Win");
			}

		}

		private void Ticker_Tick(object sender, System.EventArgs e)
		{
			AlertBox.Show("tick");
		}
	}
}
