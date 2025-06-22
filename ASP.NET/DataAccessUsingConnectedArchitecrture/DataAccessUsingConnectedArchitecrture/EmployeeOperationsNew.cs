using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Xml;


namespace DataAccessUsingConnectedArchitecrture
{
    public class EmployeeOperationsNew
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;

        public EmployeeOperationsNew()
        {
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "server=SiddharthPatil\\SIDDHARTHPATIL; database=ADODB; Integrated Security=true; encrypt=false";

        }

        public List<Employee> GetAllEmployees()
        {
            sqlCommand = new SqlCommand("select * from Emp", sqlConnection);
            List<Employee> employees = new List<Employee>();

            try
            {
                sqlConnection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();

                while(sqlDataReader.Read())
                {
                    employees.Add(new Employee()
                    {
                        Id = Convert.ToInt32(sqlDataReader["ID"]),
                        Name = Convert.ToString(sqlDataReader["Name"]),
                        Gender = Convert.ToString(sqlDataReader["Gender"]),
                        DateOfJoining = Convert.ToString(sqlDataReader["DateOfJoining"]),
                        Salary  = Convert.ToDouble(sqlDataReader["Salary"])
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

            return employees;
        }

        public Employee PrepareEmployee(int id = 0, string name = "asd asddf", string gender = "not known", string doj ="", double salary =100000)
        {
            return new Employee { Id = id, Name=name, Gender=gender, DateOfJoining=doj, Salary=salary};
        }

        public bool AddEmployee(Employee emp)
        {
            bool status = false;
            string query = $"insert into Emp values('{emp.Name}', '{emp.Gender}', '{emp.DateOfJoining}', {emp.Salary})";
            sqlCommand = new SqlCommand(query, sqlConnection);

            try
            { 
                sqlConnection.Open();
                int rowsInserted =  sqlCommand.ExecuteNonQuery();

                if (rowsInserted == 1) {
                    status = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                sqlConnection.Close();
            }

            return status;
        }

        public bool ManipulateEmployee(Employee emp, string operation)
        {
            bool status = false;

            switch (operation)
            {
                case "Add":
                    status = AddEmployee(emp);
                    break;
                default:
                    break;
            }

            return status;
        }
    }
}
