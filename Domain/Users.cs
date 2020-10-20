using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using RestSharp;

namespace Domain
{
    public class Users:Api
    {
        public string username;
        public string password;

        public async Task<String> getAResponseAsync(String body)
        {
            return await get("/weso/weso",body);
        }
    }
}
