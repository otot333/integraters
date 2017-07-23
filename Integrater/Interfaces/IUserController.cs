using Integrater.Models.Groups;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrater.Interfaces
{
    public interface IUserController
    {
        IEnumerable<GroupModel> Groups();

        GroupModel Get();

        void Update();
    }
}
