using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace GitHubRepoApp {
    public class GitHubApi {
        public async Task<List<string>> GetAsync(string user) {
            string url = $"https://api.github.com/users/{user}/repos";

            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "Other");

            var response = await client.GetAsync(url);

	        var repositories = new List<string>();
			if (response.StatusCode != HttpStatusCode.NotFound) {
				var content = await response.Content.ReadAsStringAsync();

				var json = JArray.Parse(content);
				
				if (json != null && json.Count > 0) {
					foreach(var item in json) {
						var repository = item.Value<string>("full_name");
						repositories.Add(repository);
					}
				}
				else {
					repositories.Add("User doesn't have repositories!");
				}
	        }
			else {
				repositories.Add("User not found!");
			}

            return repositories;
        }
    }
}
