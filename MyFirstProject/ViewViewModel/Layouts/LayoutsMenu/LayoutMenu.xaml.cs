using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Layouts.LayoutsMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LayoutMenu : ContentPage
    {
        public LayoutMenu()
        {
            InitializeComponent();
            BindingContext = new LayoutMenuViewModel();
        }
    }
}