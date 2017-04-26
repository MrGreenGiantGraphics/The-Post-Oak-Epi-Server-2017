using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
namespace Landrys.ThePostOak_EpiServer.Forms.ServiceApi
{
    public class OAuth2Client
    {
        private string _baseUrl, _username, _password, _accessTokenUri;

        public OAuth2Client(string baseUrl, string username, string password, string accessTokenUri)
        {
            _baseUrl = baseUrl;
            _username = username;
            _password = password;
            _accessTokenUri = accessTokenUri;
        }

        public string GetData(string uri, string accessToken)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                var response = client.GetAsync(uri).Result;
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    return content;
                }
            }

            return string.Empty;
        }

        public string GetAccessToken()
        {
            var token = string.Empty;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                var fields = new Dictionary<string, string>
               {
                   { "grant_type", "password" },
                   { "username", _username },
                   { "password", _password }
               };
                var response = client.PostAsync(_accessTokenUri, new FormUrlEncodedContent(fields)).Result;
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    token = (string)JObject.Parse(content).GetValue("access_token");
                }
            }
            return token;
        }
    }
}