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
        private static Uri BaseAddress = new Uri("https://www.lekise.net");


        public static async Task<Customer> AuthenUser(string iusername, string ipassword)
        {

            var param = new Dictionary<string, string>();

            param.Add("username", iusername);
            param.Add("password", ipassword);
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



        public static async Task<bool> UpdateCustomer(Customer customer)
        {
            var param = new Dictionary<string, string>();
            param.Add("cust_id", customer.cust_id );
            param.Add("cust_email", customer.cust_email );
            param.Add("cust_tel", customer.cust_tel );
            param.Add("cust_password", customer.cust_password );

            var content = new FormUrlEncodedContent(param);

            var client = new HttpClient();
            client.BaseAddress = BaseAddress;

            var response = await client.PostAsync("api/ptnrat/updateCustomer", content);

            return response.StatusCode == HttpStatusCode.OK;

        }


        public static async Task<ImageList> GetImageList(string ifolder)
        {

            var requestUri = "https://www.lekise.net/apps/PTNRclub/images/readdir.php?folder=" + ifolder;

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
