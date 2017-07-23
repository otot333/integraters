using Integrater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Integrater.Interfaces
{
    public interface IProjectController
    {
        IEnumerable<ProjectMgModel> Gets();

        ProjectMgModel Get(string id);
    }
}