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
                        Roll = Convert.ToInt32(sqldr["Roll"]),
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

        public bool AddNew(Student student)
        {
            bool status = false;

            sqlcmd = new SqlCommand("insert into StudentDetails values(@FirstName, @LastName, @Gender, @Email, @Qualification, @DateofBirth, @Percentage)",sqlcon);
            sqlcmd.Parameters.AddWithValue("@FirstName",student.FirstName);
            sqlcmd.Parameters.AddWithValue("@LastName", student.LastName);
            sqlcmd.Parameters.AddWithValue("@Gender", student.Gender);
            sqlcmd.Parameters.AddWithValue("@Email", student.Email);
            sqlcmd.Parameters.AddWithValue("@Qualification", student.Qualification);
            sqlcmd.Parameters.AddWithValue("@DateofBirth", student.DateofBirth);
            sqlcmd.Parameters.AddWithValue("@Percentage", student.Percentage);

            try
            {
                sqlcon.Open();
                sqlcmd.ExecuteNonQuery();
                status = true;
            }
            catch (Exception)
            {

            }

            return status;
        }

        public Student GetById(int id)
        {
            Student student = new Student();

            try
            {
                sqlcmd = new SqlCommand("select * from StudentDetails where Roll=@Roll", sqlcon);
                sqlcmd.Parameters.AddWithValue("@Roll",id);
                sqlcon.Open();
                sqldr = sqlcmd.ExecuteReader();
                while (sqldr.Read())
                {
                    student.Roll = Convert.ToInt32(sqldr["Roll"]);
                    student.FirstName = sqldr["Firstname"].ToString();
                    student.LastName = sqldr["LastName"].ToString();
                    student.Gender = sqldr["Gender"].ToString();
                    student.Email = sqldr["Email"].ToString();
                    student.Qualification = sqldr["Qualification"].ToString();
                    student.DateofBirth = sqldr["DateofBirth"].ToString();
                    student.Percentage = Convert.ToDouble(sqldr["Percentage"]);

                }
            }
            catch (Exception)
            {

            }
            finally
            {
                sqlcon.Close();
            }

            return student;
        }

        public bool EditStudent(Student editStudent)
        {
            bool status = false;

            sqlcmd = new SqlCommand("Update StudentDetails set FirstName=@FirstName, LastName=@LastName, Gender=@Gender, Email=@Email, Qualification=@Qualification, DateofBirth=@DateofBirth, Percentage=@Percentage where Roll=@Roll", sqlcon);
            sqlcmd.Parameters.AddWithValue("@Roll", editStudent.Roll);
            sqlcmd.Parameters.AddWithValue("@FirstName", editStudent.FirstName);
            sqlcmd.Parameters.AddWithValue("@LastName", editStudent.LastName);
            sqlcmd.Parameters.AddWithValue("@Gender", editStudent.Gender);
            sqlcmd.Parameters.AddWithValue("@Email", editStudent.Email);
            sqlcmd.Parameters.AddWithValue("@Qualification", editStudent.Qualification);
            sqlcmd.Parameters.AddWithValue("@DateofBirth", editStudent.DateofBirth);
            sqlcmd.Parameters.AddWithValue("@Percentage", editStudent.Percentage);

            try
            {
                sqlcon.Open();
                sqlcmd.ExecuteNonQuery();
                status = true;
            }
            catch (Exception)
            {

            }

            return status;
        }

        public bool deleteStudent(int id)
        {
            bool status = false;

            sqlcmd = new SqlCommand("delete from StudentDetails where Roll=@Roll", sqlcon);
            sqlcmd.Parameters.AddWithValue("@Roll", id);

            try
            {
                sqlcon.Open();
                sqlcmd.ExecuteNonQuery();
                status = true;
            }
            catch (Exception)
            {

            }

            return status;
        }
    }
}