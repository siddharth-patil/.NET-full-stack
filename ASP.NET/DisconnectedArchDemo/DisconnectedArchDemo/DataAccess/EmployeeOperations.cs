using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web;
using DisconnectedArchDemo.Model;

namespace DisconnectedArchDemo.DataAccess
{
    public class EmployeeOperations
    {
        SqlConnection sqlcon;
        SqlCommandBuilder sqlcmd;
        SqlDataAdapter sqlda;
        DataSet ds;

        public EmployeeOperations()
        {
            sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["ADODBConnectionString"].ConnectionString);
        }

        public DataSet CopyData()
        {
            sqlda = new SqlDataAdapter("select * from Emp",sqlcon);
            ds = new DataSet();
            sqlda.MissingSchemaAction = MissingSchemaAction.AddWithKey; 
            sqlda.Fill(ds, "Emp");
            return ds;
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

                if (searchedRecord != null) {

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

    }
}