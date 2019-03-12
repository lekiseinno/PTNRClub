using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PTNRClub.Models;
using PTNRClub.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PTNRClub
{
	public partial class PrivilegePage : ContentPage
	{
        public static string ifloder = "";

        public PrivilegePageModel _ViewModel;

        public PrivilegePage ()
		{

            ifloder = "privilege";


            InitializeComponent();



            BindingContext = _ViewModel = new PrivilegePageModel(ifloder);

        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
            _ViewModel.GetData.Execute(null);
        }


        private async void Logout_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayActionSheet("Confirm?", "Cancel", "OK", "Logout");

            if (result == "OK")
            {
                //  Helpers.Settings.IsLoggedIn = false;


                App.Current.MainPage = new LoginPage();
            }
        }




      

    }
}