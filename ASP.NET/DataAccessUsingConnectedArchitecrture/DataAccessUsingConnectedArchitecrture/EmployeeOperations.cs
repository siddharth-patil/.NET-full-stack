using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessUsingConnectedArchitecrture
{
    internal class EmployeeOperations
    {
        public static List<Employee> GetAll()
        {
            //Create connection
            string connectionString = "Server=SiddharthPatil\\SIDDHARTHPATIL;Database=ADODB; Integrated Security=true; encrypt=false";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Create sql query
            string query = "select * from Emp";

            //Add this query to command object and make sure u will authenticate yourself
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            List<Employee> employees = new List<Employee>();
            try
            {
                //Open connection
                sqlConnection.Open();

                //Execute the method
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Employee employee = new Employee { 
                        Id= Convert.ToInt32(sqlDataReader["Id"]),
                        Name = sqlDataReader["Name"].ToString(),
                        Gender = sqlDataReader["Gender"].ToString(),
                        DateOfJoining = sqlDataReader["DateOfJoining"].ToString(),
                        Salary = Convert.ToDouble(sqlDataReader["Salary"])
                    };

                    employees.Add(employee);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //close connection
                sqlConnection.Close();
            }

            return employees;
        }
    }
}
