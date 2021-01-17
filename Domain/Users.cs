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

        public async Task<Stats> refreshStats(String token)
        {
            String endpoint = "/api/users/refresh-stats";
            String body = "{}";
            HttpMethod method = HttpMethod.Get;

            try
            {
                String response = await Api.simpleRequest(endpoint, body, method, token);
                Stats stats = JsonConvert.DeserializeObject<Stats>(response);
                return stats;
            } catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public async Task<CouponsToCheckMonthly> checkCouponsMonthly(String token, String userId)
        {
            String endpoint = "/api/withdrawals/get-user-views";
            String body = $"{{\"user_id\":\"{userId}\"}}";
            HttpMethod method = HttpMethod.Get;

            try
            {
                String response = await Api.simpleRequest(endpoint, body, method, token);
                CouponsToCheckMonthly couponsToCheckMonthly = JsonConvert.DeserializeObject<CouponsToCheckMonthly>(response);
                return couponsToCheckMonthly;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        public async Task<String> banUser(String token, String userId)
        {
            String endpoint = "/api/users/ban";
            String body = "{\"user_id\":\""+userId+"\"}";
            HttpMethod method = HttpMethod.Post;

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
