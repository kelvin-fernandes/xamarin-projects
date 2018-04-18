using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ConsumingApi.Model;
using Newtonsoft.Json;

namespace ConsumingApi.Api {
    public class ApiTemperatura {
        public static async Task<RootObject> GetAsync(string local) {
            using (var _client = new HttpClient()) {
                string url = "http://api.openweathermap.org/data/2.5/weather?q="
                             + local
                             + "&appid=43245feafa0b5e24d3ff8ad9f877630d";

                string json = await _client.GetStringAsync(url);
                RootObject previsao = JsonConvert.DeserializeObject<RootObject>(json);

                return previsao;
            }
        }
    }
}
