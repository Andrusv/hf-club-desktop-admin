using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace Domain
{
    public class Coupons:Api
    {
        public async Task<String> createCoupons(int coupons,String token)
        {
            String endpoint = "/api/coupons/generate";
            String body = "{\"numberOfCoupons\":"+coupons+"}";
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
