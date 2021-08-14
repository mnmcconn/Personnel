using Personnel.Data;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Personnel.Web.Controllers
{
    [RoutePrefix("api")]
    public class RoleController : ApiController
    {       
        [HttpGet]
        [Route("roles")]
        public IHttpActionResult Get()
        {
            APIResult result = new APIResult();
            try
            {
                List<Role> roles = new List<Role>();
                using (Uow _dal = new Uow(new DataContext()))
                {                    
                    roles = _dal.Roles.GetRoles();
                };

                result.SetSuccess("Roles listed successfully.", roles);
            }
            catch (Exception ex)
            {
                result.SetFailure($"Error Listing Roles: {String.Concat(ex.Message, Environment.NewLine, ex.InnerException?.Message)}");
            }

            return Ok(result);
        }      
    }
}
