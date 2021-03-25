using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Yodlee
{
    public class AccountManager
    {
        public async Task<Accounts> GetAccounts(string authToken)
        {
            const string tokenRequestUri = @"https://sandbox.api.yodlee.com:443/ysl/accounts";

            // Create the request to send to Yodlee
            var request = new HttpRequestMessage(HttpMethod.Get, tokenRequestUri);

            // Create the HttpClient object and add the version header
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("API-VERSION", "1.1");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
            // Use the HttpClient created to send the request
            var response = await client.SendAsync(request);

            // Convert the response to a string
            var jsonString = await response.Content.ReadAsStringAsync();

            // Convert the Json string to an object
            var result = JsonConvert.DeserializeObject<Accounts>(jsonString);

            // Convert the response to a string
            return result;
        }
    }
}
