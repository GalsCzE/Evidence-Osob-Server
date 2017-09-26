using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evidence_osob.Entity;

namespace Evidence_osob.Interface
{
    interface IWebClient
    {
        Task<List<User>> GetUserListAsync();
    }
}
