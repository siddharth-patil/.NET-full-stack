using CodeFirstDemo.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo.DataAccess
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext():base("name=ADODBConnectionString")
        {
            
        }
        public DbSet<StudentDetails> Students { get; set; }
    }
}
