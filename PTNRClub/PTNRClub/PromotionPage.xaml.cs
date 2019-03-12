using PTNRClub.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PTNRClub
{

	public partial class PromotionPage : ContentPage
	{

        public static string ifloder = "";

        public PromotionPageModel _ViewModel;

        public PromotionPage ()
		{
            ifloder = "promotion";


            InitializeComponent();



           BindingContext = _ViewModel = new PromotionPageModel(ifloder);
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