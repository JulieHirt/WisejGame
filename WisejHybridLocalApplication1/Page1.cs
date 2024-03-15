using Wisej.Web;
using Wisej.Hybrid;
using System.Drawing;
using System.IO;
using System.Linq;
using System;

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
			// redraw game canvas
			GameCanvas.Invalidate();
		}

		private void GameCanvas_Paint(object sender, PaintEventArgs e)
		{
			//render GameObjects on the canvas

			GameObject player = new GameObject(5, 5);//x,y


			//Get access to the assembly. 
			System.Reflection.Assembly assembly = this.GetType().Assembly;
			//Use the assembly to find an embedded resource based on the parameter imageString
			string resourceName = assembly.GetManifestResourceNames().FirstOrDefault(name => name.EndsWith("Player.png"));
			if (!String.IsNullOrEmpty(resourceName))
			{
				//create a System.Drawing.Image object
				System.IO.Stream resource = assembly.GetManifestResourceStream(resourceName);
				Image image = Image.FromStream(resource);

				Point point = new Point(player.X * FIELD_DIMENSION, player.Y * FIELD_DIMENSION);
				e.Graphics.DrawImage(image, point);
			}

		}


	}
}
