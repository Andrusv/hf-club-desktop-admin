using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Domain.objects;
using RestSharp;

namespace Domain
{
    public class Users:Api
    {
        private User usuario = new User();

        public async Task<String> loginAdminAsync(User userBody)
        {
            return await loginAdmin(userBody.username, userBody.password, userBody.apiKeyToken);
        }
    }
}
