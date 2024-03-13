using Wisej.Web;
using Wisej.Hybrid;

namespace WisejHybridLocalApplication1
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
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
	}
}
