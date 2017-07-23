using MongoDB.Bson;
using System;

namespace Integrater.Repository
{
    public class BaseModel
    {
        public ObjectId _id { get; set; }
        public ObjectId CreateUserId { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public ObjectId UpdateUserId { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
    }
}
