using LINQ_to_SQL_Classes.Data_Access;
using LINQ_to_SQL_Classes.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ_to_SQL_Classes
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        EmployeeService employeeService;
        protected void Page_Load(object sender, EventArgs e)
        { 
            employeeService = new EmployeeService();
            fetchData();
        }

        void fetchData()
        {
            GridView1.DataSource = employeeService.GetAll();
            GridView1.DataBind();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            //bool sts = employeeService.AddEmployee(new Emp { Name = txtName.Text, Gender = ddlGender.SelectedValue, DateOfJoining =Convert.ToDateTime(txtDoj.Text), Salary =Convert.ToDouble(txtSalary.Text) });
            bool sts = employeeService.AddEmployeeWithProcedure(new Emp { Name = txtName.Text, Gender = ddlGender.SelectedValue, DateOfJoining = Convert.ToDateTime(txtDoj.Text), Salary = Convert.ToDouble(txtSalary.Text) });

            if (sts)
            {
                lblMsg.Text = "Record added successfully";
                lblMsg.ForeColor = Color.Green;
                fetchData();
            }
            else
            {
                lblMsg.Text = "Problem in insertion";
                lblMsg.ForeColor = Color.Red;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            bool sts = employeeService.ManipulateEmp(new Emp { Id = Convert.ToInt32(txtId.Text), Name = txtName.Text, Gender = ddlGender.SelectedValue, DateOfJoining = Convert.ToDateTime(txtDoj.Text), Salary = Convert.ToDouble(txtSalary.Text) }, "Delete");
            if (sts)
            {
                lblMsg.Text = "Record Deleted successfully";
                lblMsg.ForeColor = Color.Green;
                fetchData();
            }
            else
            {
                lblMsg.Text = "Problem in deletion";
                lblMsg.ForeColor = Color.Red;
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            bool sts = employeeService.ManipulateEmp(new Emp {Id =Convert.ToInt32(txtId.Text), Name = txtName.Text, Gender = ddlGender.SelectedValue, DateOfJoining = Convert.ToDateTime(txtDoj.Text), Salary = Convert.ToDouble(txtSalary.Text) }, "Update");
            if (sts)
            {
                lblMsg.Text = "Record Updated successfully";
                lblMsg.ForeColor = Color.Green;
                fetchData();
            }
            else
            {
                lblMsg.Text = "Problem in Updation";
                lblMsg.ForeColor = Color.Red;
            }
        }
    }
}