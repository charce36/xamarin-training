using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace QuoteApp.Images
{
    public partial class EmbebedImage : ContentPage
    {
        public EmbebedImage()
        {
            InitializeComponent();

			image.Source = ImageSource.FromResource("QuoteApp.Resources.background.jpg");
        }
    }
}
