using GithubViewer.Core.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using GithubViewer.Core.Extensions;

namespace GithubViewer.Core.ViewModels
{
    public class RepositoryListViewModel : BaseViewModel
    {
        private string _searchTerm;
        private ObservableCollection<GithubViewer.Core.Models.Github.Repository> _projects;
        private IGHRepositoryService _gHRepositoryService;
        public RepositoryListViewModel()
        {
            _gHRepositoryService = new GHRepositoryService();
        }
        public ICommand SearchCommand => new Command<string>(OnSearchClick);

        public string SearchTerm
        {
            get { return _searchTerm; }
            set
            {
                _searchTerm = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<GithubViewer.Core.Models.Github.Repository> Projects
        {
            get => _projects;
            set
            {
                _projects = value;
                OnPropertyChanged();
            }
        }

        public async void OnSearchClick(string repoName)
        {
            var collection = (await _gHRepositoryService.SearchRepositoriesAsync(null)).ToObservableCollection();
            Projects = collection;
        }
    }
}
