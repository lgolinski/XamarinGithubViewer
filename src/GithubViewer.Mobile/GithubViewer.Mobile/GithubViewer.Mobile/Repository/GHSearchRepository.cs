using GithubViewer.Core.Models.Github;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace GithubViewer.Core.Repository
{
    // TODO: Move Api Url to seperated global settings class.
    // TODO: Change to generic version of crud operations.
    public class GHSearchRepository
    {
        private string _apiUrl = "https://api.github.com/";
        private string _searchRepoUrl = "search/repositories?q=tetris+language:assembly&sort=stars&order=desc";

        public async Task<RepositoryResponse> GetAsync()
        {
            var getUrl = $"{_apiUrl}{_searchRepoUrl}";
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await httpClient.GetAsync(getUrl);

            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                var json = JsonConvert.DeserializeObject<RepositoryResponse>(jsonResult);

                return json;
            }

            throw new HttpRequestException();
        }
    }
}
