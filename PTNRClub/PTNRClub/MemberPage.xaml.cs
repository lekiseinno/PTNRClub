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
    public partial class MemberPage : ContentPage
    {
        public MemberPage()
        {
            InitializeComponent();
        }

 
        private async void Logout_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayActionSheet("Confirm?", "Cancel", "OK", "Logout");

            if (result == "OK")
            {
                //  Helpers.Settings.IsLoggedIn = false;


                App.Current.MainPage  = new LoginPage();
            }
        }
    }
}
