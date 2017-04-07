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
	public partial class MainMenu : ContentPage
	{
		public MainMenu ()
		{
            
            InitializeComponent();

            Contact.BackgroundColor = Color.Red;
            fuel.BackgroundColor = Color.Red;
            reg.BackgroundColor = Color.Red;
            abouUs.BackgroundColor = Color.Red;
            support.BackgroundColor = Color.Red;


            fuel.Clicked += (object sender, EventArgs e) => { Navigation.PushModalAsync(new ViborSposoba(), true); };
            reg.Clicked += (object sender, EventArgs e) => { Navigation.PushModalAsync(new UserPersCab(),true); };
            abouUs.Clicked += (object sender, EventArgs e) => { Navigation.PushModalAsync(new AboutUs(), true); };
            support.Clicked += (object sender, EventArgs e) => { };
            Contact.Clicked += (object sender, EventArgs e) => {Navigation.PushModalAsync(new contacts(), true); };
            
		}
	}
}
