﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Layouts.AbsoluteLayoutProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbsoluteLayoutProjectView : ContentPage
    {
        public AbsoluteLayoutProjectView()
        {
            InitializeComponent();
            BindingContext = new AbsoluteLayoutProjectView();
        }
    }
}