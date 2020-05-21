using GithubViewer.Core.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using GithubViewer.Core.Extensions;
using GithubViewer.Core.Models.Github;

namespace GithubViewer.Core.ViewModels
{
    public class RepositoryListViewModel : BaseViewModel
    {
        private string _searchTerm;
        private ObservableCollection<Project> _projects;
        private IGHProjectService _gHRepositoryService;
        public RepositoryListViewModel()
        {
            _gHRepositoryService = new GHProjectService();
            OnSearchClick(null);
        }
        public ICommand SearchCommand => new Command<string>(OnSearchClick);
        public ICommand RefreshCommand => new Command<string>(OnSearchClick);

        public string SearchTerm
        {
            get { return _searchTerm; }
            set
            {
                _searchTerm = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Project> Projects
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
            Projects = (await _gHRepositoryService.SearchRepositoriesAsync(repoName)).ToObservableCollection();
        }

    }
}
