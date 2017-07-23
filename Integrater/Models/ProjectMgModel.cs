using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Integrater.Models
{
    public class ProjectMgModel
    {
        public ObjectId _id { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
    }
}