using RestSharp.Serialization;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public abstract class Api
    {
        static readonly HttpClient client = new HttpClient();
        static readonly String uri = "http://localhost:3000";

        public static async Task<String> simpleRequest(string endpoint, String body, HttpMethod Method, String token)
        {
            try
            {
                String url = uri + endpoint;

                var handler = new WinHttpHandler();
                var client = new HttpClient(handler);

                var request = new HttpRequestMessage
                {
                    Method = Method,
                    RequestUri = new Uri(url),
                    Content = new StringContent(body, Encoding.UTF8, ContentType.Json),
                };

                request.Headers.Add("Authorization", "Bearer "+token);

                var response = await client.SendAsync(request).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();

                var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                return responseBody.ToString();
            }
            catch (HttpRequestException e)
            {
                return e.Message.ToString();
            }
        }

        public static async Task<String> loginAdmin(String username, String password, String token)
        {
            try
            {
                String url = uri + "/api/auth/sign-in-admin";

                var handler = new WinHttpHandler();
                var client = new HttpClient(handler);

                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri(url),
                    Content = new StringContent("{ \"apiKeyToken\": \"" + token +"\" }", Encoding.UTF8, ContentType.Json),
                };

                var byteArray = Encoding.ASCII.GetBytes($"{username}:{password}");
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
                
                var response = await client.SendAsync(request).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();

                var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                return responseBody.ToString();
            }
            catch (HttpRequestException e)
            {
                return e.Message.ToString();
            }
        }
    }
}
