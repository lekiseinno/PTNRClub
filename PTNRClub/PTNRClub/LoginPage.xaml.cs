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
        public LoginPage()
        {
            InitializeComponent();
            loginButton.Clicked += LoginButton_Clicked;
        }


        async void LoginButton_Clicked(object sender, EventArgs e)
        {
            //   var customer = Helpers.Database.Current.AuthenUser(usernameEntry.Text,passwordEntry.Text);

            indicator.IsVisible = true;
            var customer = await Helpers.Service.AuthenUser(usernameEntry.Text, passwordEntry.Text);
            indicator.IsVisible = false;



            if (customer != null)
            {
                Helpers.Settings.CusID = customer.cust_id;
                Helpers.Settings.Name = customer.cust_name;
                Helpers.Settings.Surname = customer.cust_surname;
                Helpers.Settings.Password  = customer.cust_password;
                Helpers.Settings.Email  = customer.cust_email;
                Helpers.Settings.Point = customer.point;
                Helpers.Settings.CardNo = customer.cust_card;
                Helpers.Settings.Telephone = customer.cust_tel;
                Helpers.Settings.DateExp = customer.cust_expdate;
                Helpers.Settings.IsLoggedIn = true;

               


                await Navigation.PushModalAsync(new MainPage());


            }

            else await DisplayAlert("Warning", "Username or Password incorrect!!", "OK");

        }

    }
}