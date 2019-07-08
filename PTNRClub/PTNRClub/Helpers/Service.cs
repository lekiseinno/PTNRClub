using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
        // private static Uri BaseAddress = new Uri("http://lekise.dyndns.biz:8081");

        private static Uri BaseAddress = new Uri("http://10.10.2.31:8081");



        public static async Task<Customer> AuthenUser(string iusername, string ipassword)
        {

            var param = new Dictionary<string, string>();

            param.Add("signinusername", iusername);
            param.Add("signinpassword", ipassword);
            param.Add("appname", "PTNRCLUB");

            var content = new FormUrlEncodedContent(param);

            var client = new HttpClient();
            client.BaseAddress = BaseAddress;


            var response = await client.PostAsync("api/ptnrat/auth", content);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var json = await response.Content.ReadAsStringAsync();

                if (json != "null")
                {

                    var customer = JObject.Parse(json).ToObject<Customer>();


                    return customer;
                }
                else return null;
            }
            else return null;
        }





        public static async Task<ImageList> GetImageList(string ifolder)
        {

            var requestUri = "http://10.10.2.31:8081/apps/PTNRclub/images/readdir.php?folder=" + ifolder;

            //var requestUri = "http://lekise.dyndns.biz:8081/apps/PTNRclub/images/readdir.php?folder=" + ifolder;


            using (var client = new HttpClient())
            {


                var result = await client.GetStringAsync(requestUri);
                if (result != null)
                {
                    return JsonConvert.DeserializeObject<ImageList>(result);
                }
                else return null;

               
            }


        }



        public static async Task<List<HistoryList>> GetHistory(string icustid)
        {
            var param = new Dictionary<string, string>();

            param.Add("cust_id", icustid);
 
          

            var content = new FormUrlEncodedContent(param);

            var client = new HttpClient();
            client.BaseAddress = BaseAddress;


            var response = await client.PostAsync("api/ptnrat/getHistory", content);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var json = await response.Content.ReadAsStringAsync();

                if (json != "null")
                {

                    var historyPoint = JArray.Parse(json).ToObject<List<HistoryList>>();
                    return historyPoint;


                 
                }
                else return null;
            }
            else return null;


        }


    }
}
