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
	public partial class DetailPage : ContentPage
	{
       public static string iphoto = "";

		public DetailPage (string vphoto)


		{
			InitializeComponent ();
            imageview.Source = ImageSource.FromUri(new Uri(vphoto));

        }
	}
}