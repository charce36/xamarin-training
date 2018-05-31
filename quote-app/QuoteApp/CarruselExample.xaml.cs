using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace QuoteApp
{
    public partial class CarruselExample : ContentPage
    {
		void BtnPrev_Clicked(object sender, EventArgs e)
		{
			CurrentImage--;
            SetImage();
		}
   
		void BtnNext_Clicked(object sender, EventArgs e)
		{
			CurrentImage++;
            SetImage();
		}

		public int CurrentImage 
		{
			get;
			set;
        }

		private void SetImage()
		{
			var imageSource = new UriImageSource { Uri = new Uri("https://picsum.photos/1920/1080?image=" + CurrentImage) };
			imageSource.CachingEnabled = true;
			imgCarrusel.Source = imageSource;
		}

		public CarruselExample()
        {
			InitializeComponent();

			btnNext.Clicked += BtnNext_Clicked;
            btnPrev.Clicked += BtnPrev_Clicked;

			CurrentImage = 0;
			SetImage();
        }
    }
}
