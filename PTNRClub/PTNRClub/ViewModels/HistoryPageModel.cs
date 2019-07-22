using PTNRClub.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamvvm;
using MvvmHelpers;

namespace PTNRClub.ViewModels
{
    public class HistoryPageModel
    {


        public Command GetData { get; set; }
        public ObservableRangeCollection<HistoryList> HistoryItems { get; } = new ObservableRangeCollection<HistoryList>();


        public HistoryPageModel()
        {

            GetData = new Command(async () => await GetDataCommand());

        }


        private async Task GetDataCommand()
        {


            var historylist = await Helpers.Service.GetHistory(Helpers.Settings.CusID);

            List<HistoryList> HistoryList;

            if (historylist == null)
            {

                HistoryItems.Clear();

            }
            else
            {
                HistoryList = historylist;

                HistoryItems.ReplaceRange(HistoryList);

            }


        }
    }


}
