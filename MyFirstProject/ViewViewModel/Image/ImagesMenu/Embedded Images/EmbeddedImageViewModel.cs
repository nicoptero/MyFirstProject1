using MyFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Main.ImagesMenu.Embedded_Images
{

    public class EmbeddedImageViewModel : ContentPage
    {
        public ImageSource EmbeddedImageSource { get; set; }       
    public EmbeddedImageViewModel()
        {
            Title = Titles.EmbeddedImageTitle;
            this.GetEmbeddedImageSrc();
        }

    private void GetEmbeddedImageSrc()
        {
            EmbeddedImageSource = ImageSource.FromResource("MyFirstProject.Images.Cards.jpg");
        }
    }
}