using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace App1
{

	//[(XamlCompilationOptions.Compile)]
	public partial class Registration : ContentPage
	{
        public Registration ()
		{
			InitializeComponent ();
            Ancet.Text = "Регистрация нового пользователя\nВведите свои данные";
        }
        private async void OnButtonClicked(object sender, EventArgs e)
        {
            /*
            App.Current.Properties.Add("Name", User_name.Text);
            App.Current.Properties.Add("phone", User_mail.Text);
            App.Current.Properties.Add("mobile", User_phon.Text);
               */  
            await Navigation.PushModalAsync(new MainMenu(), true);
        }
    }
}
