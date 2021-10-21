using MyFirstProject.Models;
using MyFirstProject.ViewViewModel.Layouts.AbsoluteLayout;
using MyFirstProject.ViewViewModel.Layouts.AbsoluteLayoutProject;
using MyFirstProject.ViewViewModel.Layouts.RelativeLayout;
using MyFirstProject.ViewViewModel.Layouts.RelativeLayoutProject;
using MyFirstProject.ViewViewModels;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Layouts.LayoutsMenu
{
    public class LayoutMenuViewModel : BaseViewModel
    {
        public ICommand TempClicked { get; set; }

        public ICommand OnAbsoluteLayoutProjectClicked { get; set; }

        public ICommand OnRelativeLayoutClicked { get; set; }

        public ICommand OnRelativeLayoutProjectClicked { get; set; }


        public LayoutMenuViewModel()
        {
            Title = Titles.LayoutsTitle;

            TempClicked = new Command(OnAbsoluteLayoutClickedAsync);
            OnAbsoluteLayoutProjectClicked = new Command(OnAbsoluteLayoutProjectClickedAsync);

            OnRelativeLayoutClicked = new Command(OnRelativeLayoutClickedAsync);
            OnRelativeLayoutProjectClicked = new Command(OnRelativeLayoutProjectClickedAsync);
        }

        private async void OnAbsoluteLayoutClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AbsoluteLayoutView());
        }

        private async void OnAbsoluteLayoutProjectClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AbsoluteLayoutProjectView());
        }

        private async void OnRelativeLayoutClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new RelativeLayoutView());
        }

        private async void OnRelativeLayoutProjectClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new RelativeLayoutProjectView());
        }
    }
}
