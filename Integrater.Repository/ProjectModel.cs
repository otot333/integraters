using MongoDB.Bson;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Integrater.Repository
{
    public class ProjectModel : BaseModel
    {
        public ObjectId OwnerGroupId { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public IEnumerable<SpecModel> Specs { get; set; }
        public IEnumerable<EnvironmentModel> Environments { get; set; }
    }
}