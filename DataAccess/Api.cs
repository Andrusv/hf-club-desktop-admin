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

        public static async Task<String> get(string endpoint, String body)
        {
            try
            {
                String url = uri + endpoint;

                var handler = new WinHttpHandler();
                var client = new HttpClient(handler);

                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(url),
                    Content = new StringContent(body, Encoding.UTF8, ContentType.Json),
                };

                var response = await client.SendAsync(request).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();

                var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                //string responseBody = await client.GetStringAsync(url);
                return responseBody.ToString();
            }
            catch (HttpRequestException e)
            {
                return e.Message.ToString();
            }
        }
    }
}
