using DisconnectedArchDemo.DataAccess;
using DisconnectedArchDemo.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DisconnectedArchDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        EmployeeOperations obj_ref;

        string[] Gender = new string[] { "Male", "Female"};

        void LoadData()
        {
            DataSet ds = obj_ref.CopyData();
            GridView1.DataSource = ds.Tables["Emp"];
            GridView1.DataBind();
        }

        void ClearData()
        {
            txtDate.Text = string.Empty; 
            txtName.Text = string.Empty;
            txtSalary.Text = string.Empty;
            ddlGender.Items.Clear();

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            obj_ref = new EmployeeOperations();
            if (!IsPostBack)
            { 
                LoadData();
                //ClearData();

                ddlGender.DataSource = Gender; ddlGender.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(obj_ref.AddEmployee(new Employee { Name = txtName.Text, Gender = ddlGender.SelectedValue, DateOfJoining = txtDate.Text, Salary =Convert.ToDouble(txtSalary.Text)}))
            {
                lblMsg.Text = "Record inserted successfully!";
                lblMsg.ForeColor = Color.Green;

                LoadData();
                ClearData();
            }
            else
            {
                lblMsg.Text = "Problem in adding data..!!";
                lblMsg.ForeColor = Color.Red;
            }
        }
        
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (obj_ref.UpdateEmployee(new Employee {Id = Convert.ToInt32(Session["empId"]), Name = txtName.Text, Gender = ddlGender.SelectedValue, DateOfJoining = txtDate.Text, Salary = Convert.ToDouble(txtSalary.Text) }))
            {
                lblMsg.Text = "Record updated successfully!";
                lblMsg.ForeColor = Color.Green;

                LoadData();
                ClearData();
            }
            else
            {
                lblMsg.Text = "Problem in updating data..!!";
                lblMsg.ForeColor = Color.Red;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (obj_ref.DeleteEmployee((int)Session["empId"]))
            {
                lblMsg.Text = "Record deleted successfully!";
                lblMsg.ForeColor = Color.Green;

                LoadData();
                ClearData();
            }
            else
            {
                lblMsg.Text = "Problem in deleting data..!!";
                lblMsg.ForeColor = Color.Red;
            }
        }

        GridViewRow row;
        //int empId;
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            row = GridView1.SelectedRow;
            //string gndr = GridView1.SelectedRow.Cells[2].Text;
            //lblMsg.Text = row.Cells[1].Text;
            Session["empId"] =Convert.ToInt32(row.Cells[1].Text);

            txtName.Text = row.Cells[2].Text;
            ddlGender.SelectedValue = row.Cells[3].Text;
            txtDate.Text = row.Cells[4].Text;
            txtSalary.Text = row.Cells[5].Text;
        }
    }
}