using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrater.Repository
{
    public class DataEntity
    {
        public DataEntity()
        {

        }

        public void Connect()
        {
            // or use a connection string
            var client = new MongoClient("mongodb://localhost:27017");
        }
    }
}
