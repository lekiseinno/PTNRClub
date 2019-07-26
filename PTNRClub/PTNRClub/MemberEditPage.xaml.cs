using PTNRClub.Models;
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
	public partial class MemberEditPage : ContentPage
	{
		public MemberEditPage ()
		{
            InitializeComponent();


            idEntry.Text = Helpers.Settings.CusID;
            nameEntry.Text = Helpers.Settings.Name;
            surnameEntry.Text = Helpers.Settings.Surname ;
            emailEntry.Text = Helpers.Settings.Email;
            telephoneEntry.Text = Helpers.Settings.Telephone;
            passwordEntry.Text = Helpers.Settings.Password  ;

            okButton.Clicked += OkButton_Clicked;
            cancelButton.Clicked += CancelButton_Clicked;

        }


        private async void CancelButton_Clicked(object sender, EventArgs e)
        {
            var isOK = await DisplayAlert("Confirm", "Do you want to cancel ?", "Yes", "No");
            if (isOK)
            {
                await Navigation.PopAsync();
            }
        }

        private async void OkButton_Clicked(object sender, EventArgs e)
        {
            var isOK = await DisplayAlert("Confirm", "Do you want to save ?", "Yes", "No");
            if (isOK)
            {

               

                var customers = new Customer();
                customers.cust_id = idEntry.Text;
                customers.cust_name = nameEntry.Text;
                customers.cust_surname = surnameEntry.Text;
                customers.cust_email = emailEntry.Text;
                customers.cust_tel = telephoneEntry.Text;           
                customers.cust_password = passwordEntry.Text;

                indicator.IsVisible = true;
                await Helpers.Service.UpdateCustomer(customers);
                indicator.IsVisible = false;
                await Navigation.PopAsync();



            }
        }

      

    }
}