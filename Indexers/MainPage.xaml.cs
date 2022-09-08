﻿using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Indexers
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private PhoneBook phoneBook = new PhoneBook();

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void findByNameClick(object sender, RoutedEventArgs e)
        {
            string text = name.Text;
            if (!string.IsNullOrEmpty(text))
            {
                Name name = new(text);
                PhoneNumber number = this.phoneBook[name];
                phoneNumber.Text = string.IsNullOrEmpty(number.Text) ? "Not Found" : number.Text;
            }
        }

        private void findByPhoneNumberClick(object sender, RoutedEventArgs e)
        {
            // TODO:
        }

        private void addClick(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(name.Text) && !String.IsNullOrEmpty(phoneNumber.Text))
            {
                phoneBook.Add(new Name(name.Text),
                              new PhoneNumber(phoneNumber.Text));
                name.Text = "";
                phoneNumber.Text = "";
            }
        }
    }
}
