using System;
using DLToolkit.Forms.Controls;
using PTNRClub.Droid;
using PTNRClub.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(FlowListViewInternalCell), typeof(FlowListViewInternalCellRenderer))]

namespace PTNRClub.Droid.Renderers
{
    // DISABLES FLOWLISTVIEW ROW HIGHLIGHT
    public class FlowListViewInternalCellRenderer : ViewCellRenderer
    {
        protected override Android.Views.View GetCellCore(Cell item, Android.Views.View convertView, Android.Views.ViewGroup parent, Android.Content.Context context)
        {
            var cell = base.GetCellCore(item, convertView, parent, context);

            var listView = parent as Android.Widget.ListView;

            if (listView != null)
            {
                listView.SetSelector(Android.Resource.Color.Transparent);
                listView.CacheColorHint = Android.Graphics.Color.Transparent;
            }

            return cell;
        }
    }
}