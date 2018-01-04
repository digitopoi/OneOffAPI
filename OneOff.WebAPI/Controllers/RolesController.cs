using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using static OneOff.WebAPI.ApplicationUserManager;

namespace OneOff.WebAPI.Controllers
{
    [Authorize]
    [RoutePrefix("api/Roles")]
    public class RolesController : ApiController
    {
        private ApplicationRoleManager _roleManager;

        public RolesController()
        {
        }

        public RolesController(ApplicationRoleManager roleManager)
        {
            RoleManager = roleManager;
        }

        public ApplicationRoleManager RoleManager
        {
            get
            {
                return _roleManager ?? Request.GetOwinContext().GetUserManager<ApplicationRoleManager>();
            }
            private set
            {
                _roleManager = value;
            }
        }

        //[Route("{id:guid}")]
        //public async Task<IHttpActionResult> GetRole(string Id)
        //{
        //    var role = await this.RoleManager.FindByIdAsync(Id);
            
        //    if (role != null)
        //    {
        //        return Ok()
        //    }

        //}
    }
}
