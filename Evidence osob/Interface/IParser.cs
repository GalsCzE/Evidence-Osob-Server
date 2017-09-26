using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_osob.Interface
{
    interface IParser
    {
        Task<T> ParseStringAsync<T>(string response);
    }
}
