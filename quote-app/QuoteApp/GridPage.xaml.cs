using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace QuoteApp
{
    public partial class GridPage : ContentPage
    {
        public GridPage()
        {
            InitializeComponent();

            var grid = new Grid() { 
                RowSpacing = 20,
                ColumnSpacing = 40
            };


            var label = new Label() { Text = "Label 1" };

            grid.Children.Add(label, 0, 0);
            Grid.SetRowSpan(label, 2);
            Grid.SetColumnSpan(label, 2);
            Grid.SetRow(label, 0);
            Grid.SetColumn(label, 0);
        }
    }
}
