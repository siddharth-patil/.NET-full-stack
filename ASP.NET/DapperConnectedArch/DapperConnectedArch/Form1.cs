using DapperConnectedArch.DataAccess;
using DapperConnectedArch.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperConnectedArch
{
    public partial class Form1 : Form
    {
        EmployeeOperations obj_ref;
        public Form1()
        {
            InitializeComponent();
            obj_ref = new EmployeeOperations(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvEmpData.DataSource = obj_ref.GetAll();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(obj_ref.AddNew(new Employee { Name = txtName.Text, Gender = cmbGender.Text, DateOfJoining = dateTimePicker1.Text.ToString(), Salary= Convert.ToDouble(txtSalary.Text)}))
            {
                MessageBox.Show("data added successfully!!!");
            }
            else
            {
                MessageBox.Show("problem in adding data!!!");
            }
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            if (obj_ref.DeleteEmp(empId))
            {
                MessageBox.Show("employee deleted successfully!!!");
            }
            else
            {
                MessageBox.Show("problem in deleting data!!!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(obj_ref.UpdateEmp(new Employee { Id = empId, Name = txtName.Text, Gender = cmbGender.Text, DateOfJoining = dateTimePicker1.Value.ToShortDateString(), Salary =Convert.ToDouble(txtSalary.Text)}))
            {
                MessageBox.Show("New employee Updated successfully...!");
            }
            else
            {
                MessageBox.Show("Problem in updating employee.");
            }
        }

        int empId = -1;
        private void dgvEmpData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            empId = Convert.ToInt32(dgvEmpData.Rows[e.RowIndex].Cells["Id"].Value);
            txtName.Text = dgvEmpData.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            txtSalary.Text = dgvEmpData.Rows[e.RowIndex].Cells["Salary"].Value.ToString();
            cmbGender.Text = dgvEmpData.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
            dateTimePicker1.Value =Convert.ToDateTime(dgvEmpData.Rows[e.RowIndex].Cells["DateOfJoining"].Value);
            
        }
    }
}
