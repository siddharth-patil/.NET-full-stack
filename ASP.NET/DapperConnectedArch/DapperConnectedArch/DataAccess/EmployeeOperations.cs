using DapperConnectedArch.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Windows.Forms;

namespace DapperConnectedArch.DataAccess
{
    public class EmployeeOperations
    {
        SqlConnection sqlcon;

        public EmployeeOperations()
        {
            sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["ADODBConnectionString"].ConnectionString);
        }

        public List<dynamic> GetAll()
        {

            var result = sqlcon.Query("select * from Emp").ToList();

            return result;
        }

        public bool AddNew(Employee emp)
        {
            bool status = false;

            try
            {
                if (sqlcon.Execute("insert into Emp values(@Name, @Gender, @DateOfJoining, @Salary)", emp) == 1)
                {
                    status = true;
                }
            }
            catch (Exception)
            {

            }

            return status;
        }

        public bool DeleteEmp(int id)
        {
            bool status = false;

            try
            {
                if (sqlcon.Execute($"delete from Emp where Id = {id}") == 1)
                {
                    status = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return status;
        }

        public bool UpdateEmp(Employee emp)
        {
            bool status = false;

            try
            {
                if (sqlcon.Execute("Update Emp set Name=@Name, Gender = @Gender, DateOfJoining =  @DateOfJoining, Salary = @Salary where Id= @Id", emp) == 1)
                {
                    status = true;
                }
            }
            catch (Exception)
            {

            }

            return status;
        }
    }
}
