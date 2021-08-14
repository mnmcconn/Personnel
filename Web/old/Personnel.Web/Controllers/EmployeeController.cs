using Personnel.Data;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Personnel.Web.Controllers
{
    [RoutePrefix("api")]
    public class EmployeeController : ApiController
    {
        [HttpGet]
        [Route("employeesbymanagerid/{id}")]
        public IHttpActionResult Get(int id)
        {
            APIResult result = new APIResult();
            try
            {
                using (Uow _dal = new Uow(new DataContext()))
                {
                    List<Employee> employees = new List<Employee>();
                    employees =  _dal.Employees.GetEmployees(id);
                };

                result.SetSuccess("Employees listed by Manager successfully.");
            }
            catch (Exception ex)
            {
                result.SetFailure($"Error Listing Employees By Manager: {String.Concat(ex.Message, Environment.NewLine, ex.InnerException?.Message)}");
            }

            return Ok(result);
        }

        [HttpGet]
        [Route("managers")]
        public IHttpActionResult Get()
        {
            APIResult result = new APIResult();
            try
            {
                using (Uow _dal = new Uow(new DataContext()))
                {
                    List<Employee> employees = new List<Employee>();
                    employees = _dal.Employees.GetManagers();
                };

                result.SetSuccess("Managers listed successfully.");
            }
            catch (Exception ex)
            {
                result.SetFailure($"Error Listing Managers: {String.Concat(ex.Message, Environment.NewLine, ex.InnerException?.Message)}");
            }

            return Ok(result);
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
           // MessageBox.Show($"Error Saving Employee: {String.Concat(ex.Message, Environment.NewLine, ex.InnerException?.Message)}");
        }

       
    }
}
