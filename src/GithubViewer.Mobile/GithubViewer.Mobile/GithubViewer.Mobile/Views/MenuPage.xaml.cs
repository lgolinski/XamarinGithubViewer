using GithubViewer.Core.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GithubViewer.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageMaster : ContentPage
    {
        public ListView ListView;

        public MainPageMaster()
        {
            InitializeComponent();

            BindingContext = new MainPageMasterViewModel();
            ListView = MenuItemsListView;
        }
    }
}