using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrater.Repository
{
    public class MethodGroupModel : BaseModel
    {
        public ObjectId OwnerSpecId { get; set; }
        public string Name { get; set; }
        public IEnumerable<ObjectId> Methods { get; set; }
    }
}
