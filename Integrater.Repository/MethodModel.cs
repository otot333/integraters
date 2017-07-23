using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrater.Repository
{
    public class MethodModel : BaseModel
    {
        public ObjectId GroupId { get; set; }
        public string MethodName { get; set; }
        public IEnumerable<ParameterProperty> Parameters { get; set; }
    }
}
