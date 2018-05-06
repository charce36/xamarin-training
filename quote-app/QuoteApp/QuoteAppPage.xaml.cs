using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace QuoteApp
{
    public partial class QuoteAppPage : ContentPage
    {
        public List<string> Quotes;

        public QuoteAppPage()
        {
            InitializeComponent();
            sldFontSize.Value = 16;
            Quotes = new List<string>();

            Quotes.Add("Frase 01 !!");
            Quotes.Add("Frase 02 !!");
            Quotes.Add("Frase 03 !!");
        }

        void NextButton_Clicked(object sender, System.EventArgs e)
        {
            int index = new Random().Next(Quotes.Count);
            var quote = Quotes[index];

            lblQuote.Text = quote;
        }

        void SliderFontSize_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            //lblQuote.FontSize = e.NewValue;
        }
    }
}
