using Personnel.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
                List<Employee> employees = new List<Employee>();
                using (Uow _dal = new Uow(new DataContext()))
                {
                    employees = _dal.Employees.GetEmployees(id);
                };

                result.SetSuccess("Employees listed by Manager successfully.", employees);
            }
            catch (Exception ex)
            {
                result.SetFailure($"Error Listing Employees By Manager: {String.Concat(ex.Message, Environment.NewLine, ex.InnerException?.Message)}");
            }

            return Ok(result);
        }

        [HttpGet]
        [Route("managers")]
        public IHttpActionResult ListManagers()
        {
            APIResult result = new APIResult();
            try
            {
                List<Employee> employees = new List<Employee>();

                using (Uow _dal = new Uow(new DataContext()))
                {                    
                    employees = _dal.Employees.GetManagers();
                };

                result.SetSuccess("Managers listed successfully.", employees);
            }
            catch (Exception ex)
            {
                result.SetFailure($"Error Listing Managers: {String.Concat(ex.Message, Environment.NewLine, ex.InnerException?.Message)}");
            }

            return Ok(result);
        }
       
        [HttpPost]
        [Route("employee")]
        public IHttpActionResult Create(Employee req)
        {
            APIResult result = new APIResult();

            try
            {
                using (Uow _dal = new Uow(new DataContext()))
                {
                    req.CreatedOn = DateTime.Now;

                    foreach(Role r in req.Roles)
                    {                        
                        _dal.db.Entry(r).State = EntityState.Unchanged;
                    }

                    _dal.Employees.Add(req);
                    _dal.Commit();
                };

                result.SetSuccess("Employee created successfully.");

            }
            catch (Exception ex)
            {
                result.SetFailure($"Error creating Employee: {String.Concat(ex.Message, Environment.NewLine, ex.InnerException?.Message)}");
            }

            return Ok(result);
        }

    }
}
