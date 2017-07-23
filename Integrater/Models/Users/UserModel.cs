using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Integrater.Models.Users
{
    public class UserModel
    {
        public ObjectId _id { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }
}