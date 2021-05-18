using MongoDB.Bson;
using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasperChat.RealmDB
{
    class UserDb : RealmObject
    {
        
        public int Id { get; set; }

        
        public string Username { get; set; }

        
        public string Channel { get; set; }
    }

}
