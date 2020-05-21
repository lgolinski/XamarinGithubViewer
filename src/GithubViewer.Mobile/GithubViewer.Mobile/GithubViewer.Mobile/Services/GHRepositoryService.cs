using GithubViewer.Core.Models.Github;
using GithubViewer.Core.Repository;
using GithubViewer.Core.Settings;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GithubViewer.Core.Services
{
    public class GHProjectService : IGHProjectService
    {
        private IRepository _genericRepository;
        private string _projectUrl = "search/repositories";
        public GHProjectService()
        {
            _genericRepository = new GenericRepository();
        }

        public async Task<IEnumerable<Project>> SearchRepositoriesAsync(string repoName)
        {
            string searchBy;
            if (string.IsNullOrWhiteSpace(repoName))
                searchBy = "q=language:csharp&sort=stars&order=desc";
            else
                searchBy = $"&q={repoName}+language:csharp";

            var uriBuilder = new UriBuilder(ApplicationSettings.GithubApiUrl)
            {
                Path = _projectUrl,
                Query = searchBy
            };

            var repoResponse = await _genericRepository.GetAsync<ProjectResponse>(uriBuilder.ToString());

            return repoResponse.Items;
        }
    }
}
