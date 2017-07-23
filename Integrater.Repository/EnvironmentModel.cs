using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrater.Repository
{
    public class EnvironmentModel : BaseModel
    {
        public string Name { get; set; }
        
        public IEnumerable<SpecModel> Specs { get; set; }
    }
}
