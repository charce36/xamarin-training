using System;
using System.Collections.Generic;
using QuoteApp.Model;
using Xamarin.Forms;

namespace QuoteApp.Lists
{
    public partial class ListsHandlingSections : ContentPage
    {
		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			var contact = e.SelectedItem as Contact;
			DisplayAlert("Selected", contact.Name, "OK");
   		}

		void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
		{
			var contact = e.Item as Contact;
			DisplayAlert("Tapped", contact.Name, "OK");
		}

        public ListsHandlingSections()
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
