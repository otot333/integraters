using Integrater.Interfaces;
using Integrater.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Integrater.Controllers.Api
{
    [RoutePrefix("api/project")]
    public class ProjectController : ApiController, IProjectController
    {
        //public IEnumerable<ProjectMgModel> Get()
        //{
        //    // or use a connection string
        //    var client = new MongoClient("mongodb://192.168.1.200:27017");

        //    var database = client.GetDatabase("integrater");

        //    var collection = database.GetCollection<ProjectMgModel>("project");

        //    return collection.Find(new BsonDocument()).ToList();
        //}

        [Route("")]
        public IEnumerable<ProjectMgModel> Gets()
        {
            var result = new List<ProjectMgModel>();

            result.Add(new ProjectMgModel
            {
                _id = new ObjectId("5933ac2bbc0db0254a4a9661"),
                ID = "Test",
                Name = "Test Project1"
            });
            result.Add(new ProjectMgModel
            {
                _id = new ObjectId("5933ac2bbc0db0254a4a9661"),
                ID = "Test",
                Name = "Test Project2"
            });

            return result;
        }

        public ProjectMgModel Get(string id)
        {
            throw new NotImplementedException();
        }
    }
}