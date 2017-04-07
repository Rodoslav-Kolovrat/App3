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
	public partial class ViborSposoba : ContentPage
	{
		public ViborSposoba ()
   
        {
            /**
           RelativeLayout Change = new RelativeLayout();


           //Xamarin.Forms.Forms.Init();

           //Xamarin.FormsMaps.Init();   //ios
           //Xamarin.FormsMaps.Init(this, bundle);   //android


           Button a = new Button();
           a.Text = "Выбрать из списка";
           a.BackgroundColor = Color.Red;
            Change.Children.Add(a,
          Constraint.RelativeToParent((parent) =>
          {
              return parent.Width * 0.05;    // установка координаты X
           }),
          Constraint.RelativeToParent((parent) =>
          {
              return parent.Height-100;   // установка координаты Y
           }));

           Button Geo = new Button();
           Geo.Text = "Выбрать автоматически";
           Geo.BackgroundColor = Color.Red;
            Change.Children.Add(Geo,
          Constraint.RelativeToParent((parent) =>
          {
              return parent.Width *0.5;    // установка координаты X
          }),
          Constraint.RelativeToParent((parent) =>
          {
              return parent.Height - 100;   // установка координаты Y
          }));


            Content = Change;
    **/
        
            InitializeComponent();

            a.BackgroundColor = Color.Red;
            Geo.BackgroundColor = Color.Red;
            Geo.Clicked += (object sender, EventArgs e) =>
            {
                zapravka.LabTxt = "ул. Автодорожная, 7А  8-924-597-70-71";
                Navigation.PushModalAsync(new zapravka(), true);
            };
                a.Clicked += (object sender, EventArgs e) => { Navigation.PushModalAsync(new List1(), true); };
        }
    }
}
