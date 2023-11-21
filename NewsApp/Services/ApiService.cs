using NewsApp.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Services
{
    public class ApiService
    {
        public async Task<Root> GetNews(string categoryName)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync($"https://gnews.io/api/v4/top-headlines?category=general&lang=zh&country=tw{categoryName.ToLower()}&apikey=3267a1bcd682eb2fbb09970b597c7f55");
            return JsonConvert.DeserializeObject<Root>(response);
        }
    }
}
