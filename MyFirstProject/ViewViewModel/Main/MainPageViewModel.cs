using MyFirstProject.Models;
using MyFirstProject.ViewViewModel.Controls;
using MyFirstProject.ViewViewModel.Image;
using MyFirstProject.ViewViewModel.ListView;
using MyFirstProject.ViewViewModels;
using MyFirstProject.ViewViewModel.Layouts;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Main
{
    public class MainPageViewModel : BaseViewModel
    {
        public string Header { get; set; }

        public ICommand OnControlsMenuClicked { get; set; }
        public ICommand OnLayoutsMenuClicked { get; set; }
        public ICommand OnImageMenuClicked { get; set; }

        public ICommand OnListViewMenuClicked { get; set; }     

        public MainPageViewModel()
        {
            Title = Titles.MainPageTitle;
            Header = Titles.MainHeaderTitle;

            OnControlsMenuClicked = new Command(OnControlsMenuClickedAsync);
            OnLayoutsMenuClicked = new Command(OnLayoutsMenuClickedAsync);
            OnImageMenuClicked = new Command(OnImageMenuClickedAsync);
            OnListViewMenuClicked = new Command(OnListViewMenuClickedAsync);
        }

        private async void OnControlsMenuClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ControlsMenuView());
        }

        private async void OnLayoutsMenuClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new LayoutViewMenu());
        }
        
        private async void OnImageMenuClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ImageMenuView());
        }

        private async void OnListViewMenuClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ListViewMenuView());
        }
    }
}