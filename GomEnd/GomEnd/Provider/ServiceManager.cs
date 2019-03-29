using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using GomEnd.Models;
using Newtonsoft.Json;

namespace GomEnd.Provider
{
    public  class ServiceManager
    {
        private string URLCompany = "http://gomcom.azurewebsites.net/api/Companies";
        private string URLIntern = "https://gomstaj.azurewebsites.net/api/Internships";
        private async Task<HttpClient> GetClient()
        {
            HttpClient client  = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept","application/json");
            return client;
        }

        public async Task<Company>InsertCompany(Company model)
        {
            HttpClient client = await GetClient();
            var response = await client.PostAsync(
                URLCompany, new StringContent(JsonConvert.SerializeObject(model),
                    Encoding.UTF8, "application/json"));
            var mobileResult = await response.Content.ReadAsStringAsync();
            var resultCompany = JsonConvert.DeserializeObject<Company>(mobileResult);
            return resultCompany;

        }
        public async Task<Intern> InsertIntern(Intern model)
        {
            HttpClient client = await GetClient();
            var response = await client.PostAsync(
                URLIntern, new StringContent(JsonConvert.SerializeObject(model),
                    Encoding.UTF8, "application/json"));
            var mobileResult = await response.Content.ReadAsStringAsync();
            var resultIntern = JsonConvert.DeserializeObject<Intern>(mobileResult);
            return resultIntern;

        }
    }
}
