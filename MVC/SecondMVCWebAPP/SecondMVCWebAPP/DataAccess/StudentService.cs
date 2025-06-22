using SecondMVCWebAPP.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SecondMVCWebAPP.DataAccess
{
    public class StudentService
    {
        SqlConnection sqlcon;
        SqlCommand sqlcmd;
        SqlDataReader sqldr;

        public StudentService()
        {
            sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["ADODBConnectionString"].ConnectionString);
        }

        public List<Student> GetAll()
        {
            List<Student> students = new List<Student>();

            sqlcon.Open();
            try
            {
                sqlcmd = new SqlCommand("select * from StudentDetails",sqlcon);
                sqldr = sqlcmd.ExecuteReader();
                while (sqldr.Read()) {
                    students.Add(new Student
                    {
                        FirstName = sqldr["Firstname"].ToString(),
                        LastName = sqldr["LastName"].ToString(),
                        Gender = sqldr["Gender"].ToString(),
                        Email = sqldr["Email"].ToString(),
                        Qualification = sqldr["Qualification"].ToString(),
                        DateofBirth = sqldr["DateofBirth"].ToString(),
                        Percentage = Convert.ToDouble( sqldr["Percentage"])
                    });
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                sqlcon.Close();
            }

            return students;
        }

    }
}