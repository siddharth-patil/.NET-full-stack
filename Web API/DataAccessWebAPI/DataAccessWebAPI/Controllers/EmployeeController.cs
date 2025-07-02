using DataAccessWebAPI.Models;
using DataAccessWebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DataAccessWebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        EmployeeService service_ref;
        public EmployeeController()
        {
            service_ref = new EmployeeService();
        }
        // GET: api/Employee
        public List<Emp> Get()
        {
            return service_ref.GetAll();
        }

        // GET: api/Employee/5
        public Emp Get(int id)
        {
            return service_ref.GetById(id);
        }

        // POST: api/Employee
        public IHttpActionResult Post([FromBody]Emp newEmp)
        {
            if (service_ref.ManipulateEmployeeData(newEmp, "Add"))
            {
                return Ok("New employee is added successfully...");
            }
            else
            {
                return NotFound();
            }
        }

        // PUT: api/Employee/5
        public IHttpActionResult Put(int id, [FromBody]Emp editedEmp)
        {
            if (service_ref.ManipulateEmployeeData(editedEmp, "Update"))
            {
                return Ok("Updated successfully...");
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE: api/Employee/5
        public IHttpActionResult Delete(int id)
        {
            if (service_ref.ManipulateEmployeeData(service_ref.GetById(id), "Delete"))
            {
                return Ok("Employee delted successfully...");
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
