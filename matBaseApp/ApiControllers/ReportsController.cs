using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using vls.Classes.Repositories;
using vls.Models;

namespace vls.ApiControllers
{
    public class ReportsController : ApiController
    {
        [HttpGet]
        [Route("report/roles")]
        public JsonData GetRoles(RoleFilter filter)
        {
            return new RoleRepo().Get(filter);
        }
        [HttpGet]
        [Route("report/users")]
        public JsonData GetUsers(RoleFilter filter)
        {
            return new RoleRepo().Get(filter);
        }
    }
}
