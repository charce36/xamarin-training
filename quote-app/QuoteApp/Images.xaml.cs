using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace QuoteApp
{
	public partial class Images : ContentPage
	{
		public Images()
		{
			InitializeComponent();

			var imageSource = new UriImageSource { Uri = new Uri("https://picsum.photos/1920/1080?image=0") };
			imageSource.CachingEnabled = false;
			image.Source = imageSource;
		}
	}
}
