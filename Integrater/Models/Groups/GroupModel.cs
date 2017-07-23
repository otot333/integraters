using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Integrater.Models.Groups
{
    public class GroupModel
    {
        public ObjectId _id { get; set; }
        public ObjectId OwnerId { get; set; }
        public string GroupName { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public ObjectId CreateUserId { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public ObjectId UpdateUserId { get; set; }
    }
}