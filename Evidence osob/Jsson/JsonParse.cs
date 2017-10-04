using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Evidence_osob.Entity;
using Evidence_osob.Interface;

namespace Evidence_osob.Jsson
{
    class JsonParse : IParser
    {
        public async Task<T> ParseStringAsync<T>(string response)
        {
            return await Task.Factory.StartNew(() => JsonConvert.DeserializeObject<T>(response));
        }
    }
}
