using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Evidence_osob.Entity;
using System.Net.Http;
using RestSharp;
using Newtonsoft.Json;

namespace Evidence_osob
{
    /// <summary>
    /// Interakční logika pro Added.xaml
    /// </summary>
    public partial class Added : Page
    {
        //private static readonly HttpClient _Client = new HttpClient();
        //private static JavaScriptSerializer _Serializer = new JavaScriptSerializer();
        public Added()
        {
            InitializeComponent();
        }

        private void Run()
        {
            
            User us = new User();
            us.Name = jmeno.Text;
            us.Surname = prijmeni.Text;
            us.Birth_number = rod_cislo.Text;
            us.Date_number = narozeni.DisplayDate;
            us.Gender = pohlavi.Text;

            string url = "https://student.sps-prosek.cz/~sevcima14/4ITB/Insert.php";
            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-contorl", "no-cache");
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", Newtonsoft.Json.JsonConvert.SerializeObject(us), ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            //var json = _Serializer.Serialize(us);
            //var response = await Request(HttpMethod.Post, url, json, new Dictionary<string, string>());
            //string responseText = await response.Content.ReadAsStringAsync();

            //List<User> Result = _Serializer.Deserialize<List<User>>(responseText);

            //Console.WriteLine(responseText);
            //Console.ReadLine();
        }

        /*static async Task<HttpResponseMessage> Request(HttpMethod pMethod, string pUrl, string pJsonContent, Dictionary<string, string> pHeaders)
        {
            var httpRequestMessage = new HttpRequestMessage();
            httpRequestMessage.Method = pMethod;
            httpRequestMessage.RequestUri = new Uri(pUrl);
            foreach (var head in pHeaders)
            {
                httpRequestMessage.Headers.Add(head.Key, head.Value);
            }
            switch (pMethod.Method)
            {
                case "POST":
                    HttpContent httpContent = new StringContent(pJsonContent, Encoding.UTF8, "application/json");
                    httpRequestMessage.Content = httpContent;
                    break;

            }

            return await _Client.SendAsync(httpRequestMessage);
        }*/

        private void ad_Click(object sender, RoutedEventArgs e)
        {

            Run();
            //var responseString = "https://student.sps-prosek.cz/~sevcima14/4ITB/Insert.php".GetStringAsync();
            /* using (var wb = new WebClient())
             {
                 string url = "https://student.sps-prosek.cz/~sevcima14/4ITB/Insert.php";
                 var data = new NameValueCollection();
                 data["name"] = "myUser";
                 data["surname"] = "myPassword";

                 var response = wb.UploadValues(url, "POST", data);
             }

             //var client = new RestClient(url);
             //var request = new RestRequest("resource/{id}", Method.POST);
            // request.AddHeader("header", "value");
             //IRestResponse response = client.Execute(request);*/
            //IParser parser = new JsonParse();
            // MistView.ItemsSource = await parser.ParseStringAsync<List<User>>(response.Content);
            MessageBox.Show("Uživatel přidán");
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {

        }

        private void deli_Click(object sender, RoutedEventArgs e)
        {
            var client = new RestClient(""+ id_deli);
        }
    }
}
