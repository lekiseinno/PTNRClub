﻿using Newtonsoft.Json.Linq;
using PTNRClub.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PTNRClub.Helpers
{
    public static class Service
    {
        private static Uri BaseAddress = new Uri("http://lekise.dyndns.biz:8081");

        // private static Uri BaseAddress = new Uri("http://10.10.2.31:8081");



        public static async Task<User>AuthenUser(string iusername, string ipassword)
        {

            var param = new Dictionary<string, string>();

            param.Add("signinusername", iusername);
            param.Add("signinpassword", ipassword);
            param.Add("appname", "MYLEKISE");

            var content = new FormUrlEncodedContent(param);

            var client = new HttpClient();
            client.BaseAddress = BaseAddress;


            var response = await client.PostAsync("api/lekisegroup/auth", content);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var json = await response.Content.ReadAsStringAsync();

                if (json != "null")
                {

                    var user = JObject.Parse(json).ToObject<User>();


                    return user;
                }
                else return null;
            }
            else return null;
        }
    }
}
