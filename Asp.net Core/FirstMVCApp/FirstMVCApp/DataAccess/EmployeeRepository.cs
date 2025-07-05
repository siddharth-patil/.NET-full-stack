using FirstMVCApp.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace FirstMVCApp.DataAccess
{
    public class EmployeeRepository : IEmployeeRepository
    {
        SqlConnection sqlcon;
        SqlCommandBuilder sqlcmd;
        SqlDataAdapter sqlda;
        DataSet ds;

        public EmployeeRepository()
        {
            sqlcon = new SqlConnection("Data Source=SIDDHARTHPATIL\\SIDDHARTHPATIL;Initial Catalog=ADODB;Integrated Security=True;Encrypt=False");
        }

        public DataSet CopyData()
        {
            sqlda = new SqlDataAdapter("select * from Emp", sqlcon);
            ds = new DataSet();
            sqlda.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            sqlda.Fill(ds, "Emp");
            return ds;
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                ds = CopyData();
                for (int i = 0; i < ds.Tables["Emp"].Rows.Count; i++)
                {
                    employees.Add(new Employee
                    {
                        Id = Convert.ToInt32(ds.Tables["Emp"].Rows[i]["Id"]),
                        Name = ds.Tables["Emp"].Rows[i]["Name"].ToString(),
                        Gender = ds.Tables["Emp"].Rows[i]["Gender"].ToString(),
                        DateOfJoining = ds.Tables["Emp"].Rows[i]["DateOfJoining"].ToString(),
                        Salary = Convert.ToDouble(ds.Tables["Emp"].Rows[i]["Salary"])
                    });
                }
            }
            catch (Exception)
            {

            }
            return employees;
        }

        public bool AddEmployee(Employee emp)
        {
            bool status = false;

            try
            {
                ds = CopyData();

                DataRow dr = ds.Tables["Emp"].NewRow();

                dr["Name"] = emp.Name;
                dr["Gender"] = emp.Gender;
                dr["DateOfJoining"] = emp.DateOfJoining;
                dr["Salary"] = emp.Salary;

                ds.Tables["Emp"].Rows.Add(dr);

                sqlcmd = new SqlCommandBuilder(sqlda);
                sqlda.Update(ds, "Emp");

                status = true;
            }
            catch (Exception ex)
            {

            }

            return status;
        }

        public bool UpdateEmployee(Employee emp)
        {
            bool status = false;

            try
            {
                ds = CopyData();
                DataRow searchedRecord = ds.Tables["Emp"].Rows.Find(emp.Id);

                if (searchedRecord != null)
                {
                    searchedRecord["Name"] = emp.Name;
                    searchedRecord["Gender"] = emp.Gender;
                    searchedRecord["DateOfJoining"] = emp.DateOfJoining;
                    searchedRecord["Salary"] = emp.Salary;

                    sqlcmd = new SqlCommandBuilder(sqlda);
                    sqlda.Update(ds, "Emp");
                    status = true;
                }
            }
            catch (Exception)
            {

            }

            return status;
        }

        public bool DeleteEmployee(int id)
        {
            bool status = false;

            try
            {
                ds = CopyData();
                DataRow searchedRecord = ds.Tables["Emp"].Rows.Find(id);

                if (searchedRecord != null)
                {

                    searchedRecord.Delete();
                    //OR
                    //ds.Tables["Emp"].Rows.Remove(searchedRecord);

                    sqlcmd = new SqlCommandBuilder(sqlda);
                    sqlda.Update(ds, "Emp");
                    status = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return status;
        }

        Employee IEmployeeRepository.GetById(int id)
        {
            ds = CopyData();
            Employee emp = new Employee();
            DataRow searchedRecord = ds.Tables["Emp"].Rows.Find(id);
            if (searchedRecord != null)
            {
                emp.Id = Convert.ToInt32(searchedRecord["Id"]);
                emp.Name = searchedRecord["Name"].ToString();
                emp.Gender = searchedRecord["Gender"].ToString();
                emp.DateOfJoining = searchedRecord["DateOfJoining"].ToString();
                emp.Salary = Convert.ToDouble(searchedRecord["Salary"]);
            }
            return emp;
        }
    }
}
