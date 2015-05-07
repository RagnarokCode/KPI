using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace InternKPIEcreo.Teamwork
{
    class TeamDAL
    {
        //Connects to Teamwork and authenticates API token. Returns the requested Json string from server
        public static async Task<string> GetData(string _apiKey, string _endpoint)
        {
            string apiKey = _apiKey; //Apitoken can be found as seen here: http://developer.teamwork.com/index.cfm/page/enabletheapiandgetyourkey "wine982pizza"
            const string domain = "ecreo"; //.teamwork.com const hardcoded, for other domain change here
            string endpoint = _endpoint; //eg projects.json , milestones.json etc

            var client = new HttpClient { BaseAddress = new Uri("https://" + domain + ".teamwork.com") };
            client.DefaultRequestHeaders.Authorization =

            new AuthenticationHeaderValue("Basic", Convert.ToBase64String(UTF8Encoding.UTF8.GetBytes(string.Format("{0}:{1}", apiKey, "x"))));
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var data = await client.GetAsync(endpoint);
            using (Stream responseStream = await data.Content.ReadAsStreamAsync())
            {
                return new StreamReader(responseStream).ReadToEnd();
            }
        }
    }
}
