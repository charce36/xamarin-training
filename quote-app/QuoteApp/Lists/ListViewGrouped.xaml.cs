using System;
using System.Collections.Generic;
using QuoteApp.Model;
using Xamarin.Forms;

namespace QuoteApp.Lists
{
    public partial class ListViewGrouped : ContentPage
    {
        public ListViewGrouped()
        {
            InitializeComponent();

			listView.ItemsSource = new List<ContactGroup>{
				new ContactGroup("J", "J"){
					new Contact {
                    Name = "Jagger",
                    ImageUrl = "http://lorempixel.com/100/100/people/2",
                    Status = "Hey, let's talk!"
                }
				},
				new ContactGroup("M", "M"){
    					new Contact {
                        Name = "Maria Clara",
                        ImageUrl = "http://lorempixel.com/100/100/people/1"
                    }
				}
            };


        }
    }
}
