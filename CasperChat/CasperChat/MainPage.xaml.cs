using CasperChat.Pages;
using Realms;
using System;
using Xamarin.Forms;
using CasperChat.RealmDB;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;

namespace CasperChat
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnPress(object sender, EventArgs e)
        {
            var user = new User
            {
                UsernameField = Usr.Text,
                ChannelField = Ch.Text
            };

            txt.Text = $"{user.UsernameField}, {user.ChannelField}";

            

        }

        void Resize(object sender, EventArgs e)
        {
            if (switch1.IsToggled)
            {
                txt.FontSize = 30;
            }

            else { txt.FontSize = 10; }
            
        }

    }

}
 