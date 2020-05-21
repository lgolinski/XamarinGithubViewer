using GithubViewer.Core.Models.Github;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GithubViewer.Core.Services
{
    public interface IGHRepositoryService
    {
        Task<IEnumerable<GithubViewer.Core.Models.Github.Repository>> SearchRepositoriesAsync(SearchParameters searchParameter); 
    }
}
