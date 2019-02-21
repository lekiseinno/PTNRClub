using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PTNRClub.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PTNRClub
{
	public partial class PrivilegePage : ContentPage
	{

        public PrivilegePage ()
		{
            InitializeComponent();

            MyDataSource = new List<ContentData>()

            {
                new ContentData
                    {
                        ImageUrl = "http://therichmustknow.com/wp-content/uploads/2017/06/%E0%B8%9B%E0%B8%81-20.jpg",
                 
                     },
                 new ContentData
                    {
                        ImageUrl ="http://www.lekise.co.th/micro/upload/image/HomePro%20Expo%2020.jpg",
                   
                    },
                 new ContentData
                    {
                    ImageUrl = "https://www.za.in.th/wp-content/uploads/za-job-02-01-2018-51.png",
                    }
            };
                BindingContext = this;
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


        public List<ContentData> MyDataSource { get; set; }

        private int _position;
        public int Position { get { return _position; } set { _position = value; OnPropertyChanged(); } }

        public partial class ContentData
        {
            public string ImageUrl { get; set; }
            public string Name { get; set; }
        }
    }
}