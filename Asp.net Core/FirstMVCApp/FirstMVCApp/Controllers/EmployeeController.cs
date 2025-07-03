using FirstMVCApp.DataAccess;
using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployeeRepository repo_ref;

        public EmployeeController()
        {
            repo_ref = new EmployeeRepository();
        }

        public IActionResult Index()
        {
            List<Employee> employees = repo_ref.GetEmployees();
            return View("List",employees);
        }

        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            if (repo_ref.AddEmployee(emp))
            {
                return RedirectToAction("Index");
            }
            return View(emp);
            
        }
    }
}
