using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Internal;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;
using PTNRClub.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;



[assembly: ExportRenderer(typeof(TabbedPage), typeof(DroidTabbedPageRenderer))]
namespace PTNRClub.Droid.Renderers
{
    public class DroidTabbedPageRenderer : Xamarin.Forms.Platform.Android.AppCompat.TabbedPageRenderer
    {
        public DroidTabbedPageRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<TabbedPage> e)
        {
            base.OnElementChanged(e);
            var activity = (FormsAppCompatActivity)Context;

            if (e.NewElement != null)
            {
                var relativeLayout = this.GetChildAt(0) as Android.Widget.RelativeLayout;
                if (relativeLayout != null)
                {
                    var bottomNarView = relativeLayout.GetChildAt(1).JavaCast<BottomNavigationView>();
                    bottomNarView.SetShiftMode(false, false);
                }
            }
        }
    }

    public static class BottomNavigationViewUtils
    { 

        /*
         * If using progaurd use: 
           -keepclassmembers class android.support.design.internal.BottomNavigationMenuView { 
                boolean mShiftingMode; 
            }
         *
         */
        /// <summary>
        /// Enable or disable shift mode on bottom navigation view
        /// </summary>
        /// <param name="bottomNavigationView"></param>
        /// <param name="enabled"></param>
        public static void SetShiftMode(this BottomNavigationView bottomNavigationView, bool enableShiftMode, bool enableItemShiftMode)
        {
            try
            {
                var menuView = bottomNavigationView.GetChildAt(0) as BottomNavigationMenuView;
                if (menuView == null)
                {
                    System.Diagnostics.Debug.WriteLine("Unable to find BottomNavigationMenuView");
                    return;
                }


                var shiftMode = menuView.Class.GetDeclaredField("mShiftingMode");

                shiftMode.Accessible = true;
                shiftMode.SetBoolean(menuView, enableShiftMode);
                shiftMode.Accessible = false;
                shiftMode.Dispose();


                for (int i = 0; i < menuView.ChildCount; i++)
                {
                    var item = menuView.GetChildAt(i) as BottomNavigationItemView;
                    if (item == null)
                        continue;

                    item.SetShiftingMode(enableItemShiftMode);
                    item.SetChecked(item.ItemData.IsChecked);

                }

                menuView.UpdateMenuView();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Unable to set shift mode: {ex}");
            }
        }
    }
}