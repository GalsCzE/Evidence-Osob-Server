using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evidence_osob.Interface;
using Evidence_osob.Entity;
using RestSharp;

namespace Evidence_osob.WebClient
{
    class Task : IWebClient
    {
        public async Task<List<User>> GetUserListAsync()
        {
            string url = "https://student.sps-prosek.cz/~sevcima14/4ITB/dotaz.php";
            var client = new RestClient(url);
            var request = new RestRequest("/posts", Method.GET);
            IRestResponse response = client.Execute(request);
            IParser parser = new JsonParser();
            return await parser.ParseStringAsync<List<User>>(response.Content);
        }
    }
}
