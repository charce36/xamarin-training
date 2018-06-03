using System;
using System.Collections.Generic;
using QuoteApp.Model;
using Xamarin.Forms;

namespace QuoteApp.Lists
{
    public partial class ListCustomCell : ContentPage
    {
        public ListCustomCell()
        {
            InitializeComponent();
			listView.ItemsSource = new List<Contact>{
                new Contact {
                    Name = "Maria Clara",
                    ImageUrl = "http://lorempixel.com/100/100/people/1"
                },
                new Contact {
                    Name = "Jagger",
                    ImageUrl = "http://lorempixel.com/100/100/people/2",
                    Status = "Hey, let's talk!"
                },
                new Contact {
                    Name = "Olivia",
                    ImageUrl = "http://lorempixel.com/100/100/people/3"
                },
                new Contact {
                    Name = "Lupita",
                    ImageUrl = "http://lorempixel.com/100/100/people/4"
                }
            };
        }
    }
}
