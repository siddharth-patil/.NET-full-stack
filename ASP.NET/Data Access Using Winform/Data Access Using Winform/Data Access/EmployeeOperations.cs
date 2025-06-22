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
    internal class EmployeeOperations
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;

        public EmployeeOperations()
        {
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["ADODBConnectionString"].ConnectionString;
            //sqlConnection.ConnectionString = "server=SiddharthPatil\\SIDDHARTHPATIL; database=ADODB; Integrated Security=true; encrypt=false";

        }

        public List<Employee> GetAllEmployees()
        {
            sqlCommand = new SqlCommand("select * from Emp", sqlConnection);
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

        public bool AddEmployee(Employee emp)
        {
            bool status = false;
            string query = $"insert into Emp values('{emp.Name}', '{emp.Gender}', '{emp.DateOfJoining}', {emp.Salary})";
            sqlCommand = new SqlCommand(query, sqlConnection);

            try
            {
                sqlConnection.Open();
                int rowsInserted = sqlCommand.ExecuteNonQuery();

                if (rowsInserted == 1)
                {
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

        public bool AddEmployeeWithStoredProcedure(Employee newEmp)
        {
            bool status = false;

            sqlCommand = new SqlCommand("AddEmployee",sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@Name", newEmp.Name);
            sqlCommand.Parameters.AddWithValue("@Gender", newEmp.Gender);
            sqlCommand.Parameters.AddWithValue("@DateOfJoining", newEmp.DateOfJoining);
            sqlCommand.Parameters.AddWithValue("@Salary", newEmp.Salary);

            try
            {
                sqlConnection.Open();
                if(sqlCommand.ExecuteNonQuery() == 1)
                {
                    status = true;
                }
            }
            catch (Exception ex)
            {

            }
            finally 
            { 
                sqlConnection.Close();
            }

            return status;
        }

        public bool UpdateEmployee(Employee changedEmployee)
        {
            bool status = false;

            sqlCommand = new SqlCommand($"update Emp set Name='{changedEmployee.Name}',Gender='{changedEmployee.Gender}',DateOfJoining='{changedEmployee.DateOfJoining}',Salary={changedEmployee.Salary} where Id = {changedEmployee.Id}", sqlConnection);

            try
            {
                sqlConnection.Open();
                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                    status= true;
                }
            }
            catch (Exception ex)
            {
                status = false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return status;
        }

        public bool DeleteEmployee(int id)
        {
            bool status = false;

            sqlCommand = new SqlCommand($"delete from Emp where Id={id}",sqlConnection);

            try
            {
                sqlConnection.Open ();

                if(sqlCommand.ExecuteNonQuery()==1)
                {
                    status = true;
                }
            }
            catch (Exception ex)
            {
                status = false;
            }
            finally
            {
                sqlConnection.Close (); 
            }

            return status;
        }
    }
}
