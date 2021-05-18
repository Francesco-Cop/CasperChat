using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CasperChat.Pages;
using Realms;

namespace CasperChat.RealmDB
{
    class RealmDBConnect
    {

        public void RealmDb()
        {
            User user = new User();
            var realmDB = Realm.GetInstance();

            var UserObj = new UserDb()
            {
                Id = 1,
                Username = user.UsernameField,
                Channel = user.ChannelField
            };

            realmDB.Write(() =>
            {
                UserObj = realmDB.Add(UserObj);
            });
            
        }
       
    }
}
