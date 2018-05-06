using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace QuoteApp
{
    public partial class GridPhoneEx : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (lblResult.Text.Length > 12)
                return;
            
            Button btn = (Button)sender;
            lblResult.Text += btn.Text;
        }

        public GridPhoneEx()
        {
            InitializeComponent();
        }
    }
}
