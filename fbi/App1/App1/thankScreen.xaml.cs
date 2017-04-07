using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class thankScreen : ContentPage
	{
		public thankScreen ()
		{
			InitializeComponent ();
		}

        private void OnButtonClicked(object sender, EventArgs e)
        {
          //  Navigation.PushAsync(new MainPage());
            Navigation.PushModalAsync(new MainMenu(), true);
        }
    }
}
