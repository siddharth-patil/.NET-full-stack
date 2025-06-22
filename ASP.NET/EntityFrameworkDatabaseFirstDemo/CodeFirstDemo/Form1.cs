using CodeFirstDemo.DataAccess.Models;
using CodeFirstDemo.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstDemo
{
    public partial class frm_StudentForm : Form
    {
        StudentService service_ref;
        public frm_StudentForm()
        {
            InitializeComponent();
            service_ref = new StudentService();
        }

        private void frm_StudentForm_Load(object sender, EventArgs e)
        {
            fetchData();
        }

        void fetchData()
        {
            if (service_ref.GetAll().Count > 0)
            {
                dgvStudentData.DataSource = service_ref.GetAll();
            }
            else
            {
                MessageBox.Show("There is no record in Table!!!");
            }
            
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (service_ref.ManipulateData(new StudentDetails { FirstName = txtFirstName.Text, LastName = txtLastName.Text,Gender = cmbGender.Text, Email = txtEmail.Text, DateofBirth = dtpDateofBirth.Value.Date, Qualification = cmbQualification.Text, Percentage = Convert.ToDouble(txtPercentage.Text)},"Add"))
            {
                MessageBox.Show("Record Added...");
                fetchData();

            }
            else
            {
                MessageBox.Show("Problrm in adding Record!!!");
            }
        }
        int roll = 0;

        private void dgvStudentData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            roll = Convert.ToInt32(dgvStudentData.Rows[e.RowIndex].Cells["Roll"].Value);
            txtFirstName.Text = dgvStudentData.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
            txtLastName.Text = dgvStudentData.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
            cmbGender.Text = dgvStudentData.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
            txtEmail.Text = dgvStudentData.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            cmbQualification.Text = dgvStudentData.Rows[e.RowIndex].Cells["Qualification"].Value.ToString();
            dtpDateofBirth.Value = Convert.ToDateTime(dgvStudentData.Rows[e.RowIndex].Cells["DateofBirth"].Value);
            txtPercentage.Text = dgvStudentData.Rows[e.RowIndex].Cells["Percentage"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
