using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamvvm;

namespace PTNRClub.ViewModels
{
    public class NewsPageModel : BasePageModel
    {
        public static string ifloder = "";


        public Command GetData { get; set; }

        public NewsPageModel(string vfloder)
        {

            ifloder = vfloder;


            GetData = new Command(async () => await GetDataCommand());

            ItemTappedCommand = new BaseCommand(async (param) =>
            {

                var item = LastTappedItem as ItemModel;

                if (item != null)
                {

                    await App.Current.MainPage.Navigation.PushModalAsync(new DetailPage(item.ImageUrl));

                }


            });

        }



        private async Task GetDataCommand()
        {

            var list = new ObservableCollection<ItemModel>();

            var images = await Helpers.Service.GetImageList(ifloder);


            foreach (var photo in images.Photos)
            {



                var item = new ItemModel()
                {
                    ImageUrl = photo,


                };


                list.Add(item);

            }
            Items = list;




        }


        public ICommand ItemTappedCommand
        {
            get { return GetField<ICommand>(); }
            set { SetField(value); }
        }



        public object LastTappedItem
        {
            get { return GetField<object>(); }
            set { SetField(value); }
        }

        public ObservableCollection<ItemModel> Items
        {
            get { return GetField<ObservableCollection<ItemModel>>(); }
            set { SetField(value); }
        }

        public class ItemModel : BaseModel
        {
            string imageUrl;
            public string ImageUrl
            {
                get { return imageUrl; }
                set { SetField(ref imageUrl, value); }
            }


        }


    }
}
