using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PTNRClub
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
            loginButton.Clicked += LoginButton_Clicked;
        }


        async void LoginButton_Clicked(object sender, EventArgs e)
        {
            //   var customer = Helpers.Database.Current.AuthenUser(usernameEntry.Text,passwordEntry.Text);

            indicator.IsVisible = true;
            var employees = await Helpers.Service.AuthenUser(usernameEntry.Text, passwordEntry.Text);
            indicator.IsVisible = false;



            if (employees != null)
            {
                //Helpers.Settings.Name = customer.Name;
                //Helpers.Settings.Username = customer.Username;
                //Helpers.Settings.IsLoggedIn = true;

                //เทคนิค การเปลี่ยนหน้าหลักให้อยู่ใน masterDetail


               //var iPage = new NavigationPage(new MainPage())
               // {
               //     //BarBackgroundColor = Color.FromHex("#ff5300"),
               //     //BarTextColor = Color.White,
               // };


                await Navigation.PushModalAsync(new MainPage());

    
            }

            else await DisplayAlert("Warning", "Username or Password incorrect!!", "OK");

        }

    }
}