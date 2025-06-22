using EntityFrameworkDatabaseFirstDemo.DataAccess;
using EntityFrameworkDatabaseFirstDemo.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDatabaseFirstDemo
{
    public partial class frm_DatabaseFirstDemo : Form
    {
        EmployeeService service_ref;
        public frm_DatabaseFirstDemo()
        {
            InitializeComponent();
            service_ref = new EmployeeService();
            FetchData();
        }
        void FetchData()
        {
           dataGridView1.DataSource = service_ref.GetAll();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (service_ref.ManipulateData(new Employee { Name = txtName.Text, Gender = cmbGender.Text, DateofJoining = dtpDateofJoining.Value, Salary = Convert.ToDouble(txtSalary.Text) },"Add"))
            {
                MessageBox.Show("Data Added Successfully...");
                FetchData();
                
            }
            else
            {
                MessageBox.Show("Problem in Addition!!!");
            }
        }
        int empid = 0;

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            empid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            cmbGender.Text = dataGridView1.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
            dtpDateofJoining.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["DateofJoining"].Value);
            txtSalary.Text = dataGridView1.Rows[e.RowIndex].Cells["Salary"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (service_ref.ManipulateData(new Employee { Id = empid, Name = txtName.Text, Gender = cmbGender.Text, DateofJoining = dtpDateofJoining.Value, Salary = Convert.ToDouble(txtSalary.Text) }, "Update"))
            {
                MessageBox.Show("Data Updated Successfully...");
                FetchData();

            }
            else
            {
                MessageBox.Show("Problem in Updation!!!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (service_ref.ManipulateData(new Employee { Id = empid }, "Delete"))
            {
                MessageBox.Show("Data Deleted Successfully...");
                FetchData();

            }
            else
            {
                MessageBox.Show("Problem in Deletion!!!");
            }
        }
    }
}
