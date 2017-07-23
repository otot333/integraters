using MongoDB.Bson;
using System;

namespace Integrater.Repository
{
    public class GroupModel : BaseModel
    {
        public ObjectId OwnerUserId { get; set; }
        public string GroupName { get; set; }
    }
}