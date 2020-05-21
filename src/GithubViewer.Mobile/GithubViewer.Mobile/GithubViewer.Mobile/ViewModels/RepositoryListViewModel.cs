using System.Windows.Input;
using Xamarin.Forms;

namespace GithubViewer.Core.ViewModels
{
    public class RepositoryListViewModel : BaseViewModel
    {
        private string _searchTerm;
        //private ObservableCollection<Repository> _projects;
        public RepositoryListViewModel()
        {
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

        public void OnSearchClick(string repoName)
        { 
        
        }
    }
}
