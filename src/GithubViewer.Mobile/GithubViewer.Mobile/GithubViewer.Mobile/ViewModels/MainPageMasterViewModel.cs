using GithubViewer.Core.Models;
using System.Collections.ObjectModel;

namespace GithubViewer.Core.ViewModels
{
    // TODO: Use Dependency Injection to auto inject services / repositories / ViewModels.
    public class MainPageMasterViewModel : BaseViewModel
    {
        public ObservableCollection<MainPageMenuItem> MenuItems { get; set; }

        public MainPageMasterViewModel()
        {
            MenuItems = new ObservableCollection<MainPageMenuItem>(new[]
            {
                    new MainPageMenuItem { Id = 0, Title = "Repositories" },
                    new MainPageMenuItem { Id = 1, Title = "FavouriteProjects" },
                });
        }
    }
}