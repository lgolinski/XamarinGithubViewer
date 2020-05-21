using GithubViewer.Core.Models;
using GithubViewer.Core.Views;
using System.Collections.ObjectModel;

namespace GithubViewer.Core.ViewModels
{
    // TODO: Use Dependency Injection to auto inject services / repositories / ViewModels.
    public class MainPageMasterViewModel : BaseViewModel
    {
        public ObservableCollection<MainPageMenuItem> MenuItems { get; set; }

        public string LogoUrl { get; set; } = "github_logo.png";

        public MainPageMasterViewModel()
        {
            MenuItems = new ObservableCollection<MainPageMenuItem>(new[]
            {
                new MainPageMenuItem { Id = 0, Title = "Repositories", ImageUrl = "ic_code.png", TargetType = typeof(RepositoryListPage) },
                new MainPageMenuItem { Id = 1, Title = "Favorite Projects", ImageUrl = "ic_favorite.png", TargetType = typeof(FavoriteProjectsPage) },
            });
        }
    }
}