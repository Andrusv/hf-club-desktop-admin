using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Domain
{
    public class Withdrawals
    {
        public async Task<String> getPendingWithdrawals(String token)
        {
            String endpoint = "/api/withdrawals/pending-withdrawals";
            String body = "{}";
            HttpMethod method = HttpMethod.Get;

            try {
                return await Api.simpleRequest(endpoint,body,method,token);
            } catch(Exception ex)
            {
                return ex.ToString();
            }
        }

        public async Task<String> getAprovedWithdrawals(String token)
        {
            String endpoint = "/api/withdrawals/aproved-withdrawals";
            String body = "{}";
            HttpMethod method = HttpMethod.Get;

            try
            {
                return await Api.simpleRequest(endpoint, body, method, token);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public async Task<String> aproveWithdrawals(String token, int withdrawal_id)
        {
            String endpoint = "/api/withdrawals/pay";
            String body = $"{{\"withdrawal_id\":{withdrawal_id}}}";
            HttpMethod method = HttpMethod.Post;

            try
            {
                return await Api.simpleRequest(endpoint, body, method, token);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
