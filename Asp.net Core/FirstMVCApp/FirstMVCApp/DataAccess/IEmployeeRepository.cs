using FirstMVCApp.Models;

namespace FirstMVCApp.DataAccess
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
        public bool AddEmployee(Employee employee);
        public bool UpdateEmployee(Employee employee);
        public bool DeleteEmployee(int id);
    }
}
