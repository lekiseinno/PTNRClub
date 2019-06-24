using Plugin.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace PTNRClub.Helpers
{
    public static class Settings

    {
        public static string Name
        {
            get { return CrossSettings.Current.GetValueOrDefault("Name", ""); }
            set { CrossSettings.Current.AddOrUpdateValue("Name", value); }
        }

        public static string Surname
        {
            get { return CrossSettings.Current.GetValueOrDefault("Surname", ""); }
            set { CrossSettings.Current.AddOrUpdateValue("Surname", value); }
        }


        public static string CardNo
        {
            get { return CrossSettings.Current.GetValueOrDefault("CardNo", ""); }
            set { CrossSettings.Current.AddOrUpdateValue("CardNo", value); }
        }


        public static int Point
        {
            get { return CrossSettings.Current.GetValueOrDefault("Point", 0); }
            set { CrossSettings.Current.AddOrUpdateValue("Point", value); }
        }

        public static bool IsLoggedIn
        {
            get { return CrossSettings.Current.GetValueOrDefault("IsLoggedIn", false); }
            set { CrossSettings.Current.AddOrUpdateValue("IsLoggedIn", value); }
        }

        public static string Email
        {
            get { return CrossSettings.Current.GetValueOrDefault("Email", ""); }
            set { CrossSettings.Current.AddOrUpdateValue("Email", value); }
        }


        public static string Telephone
        {
            get { return CrossSettings.Current.GetValueOrDefault("Telephone", ""); }
            set { CrossSettings.Current.AddOrUpdateValue("Telephone", value); }
        }
    }
}
