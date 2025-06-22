using Data_Access_Using_Winform.Data_Access.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Using_Winform.Data_Access
{
    class EmployeeOperationsNew
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;
        public EmployeeOperationsNew()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ADODBConnectionString"].ConnectionString);

        }

        public bool ManipulateEmployee(Employee emp, string Operation)
        {
            bool status = false;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "CRUDEmployeeOperations";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@Id",emp.Id);
            sqlCommand.Parameters.AddWithValue("@Name",emp.Name);
            sqlCommand.Parameters.AddWithValue("@DateOfJoining",emp.DateOfJoining);
            sqlCommand.Parameters.AddWithValue("@Gender",emp.Gender);
            sqlCommand.Parameters.AddWithValue("@Salary",emp.Salary);
            sqlCommand.Parameters.AddWithValue("@Operation",Operation);

            try
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                status = true;

            }
            catch (Exception)
            {

            }
            finally
            {
                sqlConnection.Close();
            }


            return status;
        }

        public List<Employee> GetAll()
        {
            sqlCommand = new SqlCommand("CRUDEmployeeOperations", sqlConnection);
            sqlCommand.CommandType=CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("Operation","Select");

            List<Employee> employees = new List<Employee>();

            try
            {
                sqlConnection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    employees.Add(new Employee()
                    {
                        Id = Convert.ToInt32(sqlDataReader["ID"]),
                        Name = Convert.ToString(sqlDataReader["Name"]),
                        Gender = Convert.ToString(sqlDataReader["Gender"]),
                        DateOfJoining = Convert.ToString(sqlDataReader["DateOfJoining"]),
                        Salary = Convert.ToDouble(sqlDataReader["Salary"])
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
    }
}
