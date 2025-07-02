using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Services;
using WebAPI.Models;


namespace WebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        EmployeeService service_ref;
        public EmployeeController()
        {
            service_ref = new EmployeeService();
        }
        // GET: api/Employee
        public IHttpActionResult Get()
        {
            List<Emp> res = service_ref.GetAll();
            if (res.Count > 0) 
            {
                return Ok(res);
            }
            else 
            {
                return BadRequest("No Data!!");
            }
        }

        // GET: api/Employee/5
        public IHttpActionResult Get(int id)
        {
            Emp emp = service_ref.GetById(id);
            if (emp != null)
            {
                return Ok(emp);
            }
            else
            {
                return NotFound();
            }
        }

        // POST: api/Employee
        public IHttpActionResult Post([FromBody]Emp emp)
        {
            if (service_ref.ManipulateEmployee(emp, "Add"))
            {
                return Ok("Added successfully...");
            }
            return BadRequest("Problem in adding...");
        }

        // PUT: api/Employee/5
        public IHttpActionResult Put(int id, [FromBody]Emp editedEmp)
        {
            if(service_ref.ManipulateEmployee(editedEmp,"Update"))
            {
                return Ok("Updated successfully.....");
            }
            return BadRequest("Problem in updating...");
        }

        // DELETE: api/Employee/5
        public IHttpActionResult Delete(int id)
        {
            if (service_ref.ManipulateEmployee(new Emp { Id = id},"Delete"))
            {
                return Ok("Deleted Successfully...");
            }
            return BadRequest("Problem in deletion..");
        }
    }
}
