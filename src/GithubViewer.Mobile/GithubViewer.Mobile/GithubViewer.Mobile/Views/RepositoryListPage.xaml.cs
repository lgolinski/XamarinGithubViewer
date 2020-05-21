using GithubViewer.Core.ViewModels;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GithubViewer.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RepositoryListPage : ContentPage
    {
        public RepositoryListPage()
        {
            InitializeComponent();
            BindingContext = new RepositoryListViewModel();
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
