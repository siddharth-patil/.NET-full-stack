using AdoDotNet_ConnArch_Feature.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoDotNet_ConnArch_Feature
{
    public partial class frm_MultipleQueries : Form
    {
        SqlConnection sqlcon;
        SqlCommand sqlcmd;
        SqlDataReader sqldr;

        public frm_MultipleQueries()
        {
            InitializeComponent();
            sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["FeaturesConnectionString"].ConnectionString);
            
        }

        private void btnMultipleQueries_Click(object sender, EventArgs e)
        {
            sqlcmd = new SqlCommand("select * from Emp; select * from Student",sqlcon);

            try
            {
                sqlcon.Open();
                sqldr = sqlcmd.ExecuteReader();
                List<Employee> employees = new List<Employee>();

                while (sqldr.Read())
                {
                    Employee employee = new Employee
                    {
                        Id = Convert.ToInt32(sqldr["Id"]),
                        Name = sqldr["Name"].ToString(),
                        Gender = sqldr["Gender"].ToString(),
                        DateOfJoining = sqldr["DateOfJoining"].ToString(),
                        Salary = Convert.ToDouble(sqldr["Salary"])
                    };
                    employees.Add(employee);
                }
                dgvEmployee.DataSource = employees;

                if (sqldr.NextResult())
                {
                    //No need to do execute reader again-> sqldr = sqlcmd.ExecuteReader();
                    List<Student> students = new List<Student>();

                    while (sqldr.Read())
                    {
                        students.Add(new Student
                        {
                            Roll = Convert.ToInt32(sqldr["Roll"]),
                            Name = sqldr["Name"].ToString(),
                            Percentage = Convert.ToDouble(sqldr["Percentage"])
                        });
                    }

                    dgvStudent.DataSource = students;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { sqlcon.Close(); }
        }
    }
}
