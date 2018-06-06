using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using QuoteApp.Model;
using Xamarin.Forms;

namespace QuoteApp.Lists
{
    public partial class ListsContextActions : ContentPage
    {
		private ObservableCollection<Contact> _contacts;

		void Delete_Clicked(object sender, System.EventArgs e)
		{
			var contact = (sender as MenuItem).CommandParameter as Contact;
			_contacts.Remove(contact);
		}

		void Call_Clicked(object sender, System.EventArgs e)
		{
			var menuItem = sender as MenuItem;
			var contact = menuItem.CommandParameter as Contact;

			DisplayAlert("Call", contact.Name, "OK");
		}

        public ListsContextActions()
        {
            InitializeComponent();

			_contacts = new ObservableCollection<Contact>{
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

			listView.ItemsSource = _contacts;
        }
    }
}
