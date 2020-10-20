using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.objects;
using Domain.objects;
using Newtonsoft.Json;
using RestSharp;

namespace Domain
{
    public class Users:Api
    {
        private User usuario = new User();

        public async Task<String> loginAdminAsync(User userBody)
        {
            var serverResponse = await loginAdmin(userBody.username, userBody.password, userBody.apiKeyToken);

            
            if (serverResponse.error == null)
            {
                return JsonConvert.SerializeObject(serverResponse);
            } else
            {
                return serverResponse.error;
            }
        }
    }
}
