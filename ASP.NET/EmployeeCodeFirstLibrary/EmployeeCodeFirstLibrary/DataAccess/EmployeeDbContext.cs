using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EmployeeCodeFirstLibrary.Model;

namespace EmployeeCodeFirstLibrary.DataAccess
{
    public class EmployeeDbContext:DbContext
    {

        public EmployeeDbContext() :base("CodeFirstConnectionString")
        {
            Database.SetInitializer<EmployeeDbContext>(new EmployeeDBInitializer());
        }

        public DbSet<EmployeeMVC> Employees { get; set; }
    }
}
