using Integrater.Repository.Enums;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrater.Repository
{
    public class SpecModel : BaseModel
    {
        public string Version { get; set; }
        public SpecStatusEnum Status { get; set; }
    }
}
