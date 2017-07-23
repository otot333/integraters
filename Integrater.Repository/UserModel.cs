using MongoDB.Bson;
using System;

namespace Integrater.Repository
{
    public class UserModel : BaseModel
    {
        public string Account { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }
}