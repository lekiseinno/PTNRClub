using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.PlatformConfiguration;

using Xamarin.Forms.Xaml;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.WindowsSpecific;

namespace PTNRClub
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : Xamarin.Forms.TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
           // On<Windows>().SetHeaderIconsEnabled(true);
        }

       
    }
}
