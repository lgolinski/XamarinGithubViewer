using GithubViewer.Core.Models.Github;
using GithubViewer.Core.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GithubViewer.Core.Services
{
    public class GHRepositoryService : IGHRepositoryService
    {
        private readonly GHSearchRepository _ghSearchRepository;
        public GHRepositoryService()
        {
            _ghSearchRepository = new GHSearchRepository();
        }

        // TODO: Implement SearchParameters object.
        public async Task<IEnumerable<GithubViewer.Core.Models.Github.Repository>> SearchRepositoriesAsync(SearchParameters searchParameter)
        {
            var repoResponse = await _ghSearchRepository.GetAsync();

            return repoResponse.Items;
        }
    }
}
