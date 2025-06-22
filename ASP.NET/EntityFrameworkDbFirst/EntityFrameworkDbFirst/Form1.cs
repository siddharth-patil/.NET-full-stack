using EntityFrameworkDbFirst.Data_Access;
using EntityFrameworkDbFirst.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDbFirst
{
    public partial class frm_DbFirst : Form
    {
        EmployeeService employeeService;
        public frm_DbFirst()
        {
            InitializeComponent();
            employeeService = new EmployeeService();
            fetchData();
        }

        void fetchData()
        {
            dataGridView1.DataSource = employeeService.GetAll();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (employeeService.ManipulateData(new Emp {Name = txtName.Text, DateOfJoining = dtpDoj.Value, Gender = cmbGender.Text, Salary =Convert.ToDouble( txtSalary.Text) },"Add"))
            {
                MessageBox.Show("Data added successfully");
                fetchData();
            }
            else
            {
                MessageBox.Show("Problem in addition...");
            }
        }



        int empId = 0;
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            empId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            txtSalary.Text = dataGridView1.Rows[e.RowIndex].Cells["Salary"].Value.ToString();
            cmbGender.Text = dataGridView1.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
            //dtpDoj.Text = dataGridView1.Rows[e.RowIndex].Cells["DateOfJoining"].Value.ToString();
            dtpDoj.Value =Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["DateOfJoining"].Value);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (employeeService.ManipulateData(new Emp {Id = empId, Name = txtName.Text, DateOfJoining = dtpDoj.Value, Gender = cmbGender.Text, Salary = Convert.ToDouble(txtSalary.Text) }, "Update"))
            {
                MessageBox.Show("Data updated successfully");
                fetchData();
            }
            else
            {
                MessageBox.Show("Problem in updation...");
            }
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            if (employeeService.ManipulateData(new Emp { Id = empId }, "Delete"))
            {
                MessageBox.Show("Data deleted successfully");
                fetchData();
            }
            else
            {
                MessageBox.Show("Problem in deletion...");
            }
        }
    }
}
