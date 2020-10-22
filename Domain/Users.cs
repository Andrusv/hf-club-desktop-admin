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

        public async Task<LoginResponse> loginAdminAsync(User userBody)
        {
            LoginInfo writeData = new LoginInfo();

            var serverResponse = await loginAdmin(userBody.username, userBody.password, userBody.apiKeyToken);

            if (serverResponse.error == null)
            {
                writeData.jwt = serverResponse.token;
                writeData.sessionExpire = DateTime.Now.AddHours(23);
                writeData.error = null;

                FileSystem.writeJwt(writeData);
            }

            return serverResponse;
        }

        public async Task<String> refreshStats(String token)
        {
            String endpoint = "/api/users/refresh-stats";
            String body = "{}";
            HttpMethod method = HttpMethod.Get;

            try
            {
                return await Api.simpleRequest(endpoint, body, method, token);
            } catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
