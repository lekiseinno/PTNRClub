using PTNRClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PTNRClub.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardView : Frame
    {
        public CardView()
        {
            InitializeComponent();
            nameEntry.Text = Helpers.Settings.Name;
            surnameEntry.Text = Helpers.Settings.Surname;
            cardIDEntry.Text = SubCardNo();
        }

        public String SubCardNo()
        {
            String icard_id = "";
            String icardno = "";
            String icard1 = "";
            String icard2 = "";
            String icard3 = "";
            String icard4 = "";

            icard_id = Helpers.Settings.CardNo;

            icard1 = icard_id.Substring(0, 4);
            icard2 = icard_id.Substring(4, 4);
            icard3 = icard_id.Substring(8, 4);
            icard4 = icard_id.Substring(12, 4);

            icardno = icard1 + "  " + icard2 + "  " + icard3 + "  " + icard4;

            return icardno;
        }


        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            boxCardColor.HeightRequest = boxCardColor.Width / 16 * 9;
            imgCard.HeightRequest = imgCard.Width / 16 * 9;

        }

         void Card_Tapped(object sender, EventArgs  e)
        {


            //var menu = sender as TapGestureRecognizer;

      
            //var customer =  new Customer();
            //await Navigation.PushAsync(new MemberEditPage(customer));

              Navigation.PushAsync(new MemberEditPage ());
        }
    }
}