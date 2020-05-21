using GithubViewer.Core.Models.Github;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GithubViewer.Core.Services
{
    public interface IGHProjectService
    {
        Task<IEnumerable<Project>> SearchRepositoriesAsync(string repoName); 
    }
}
