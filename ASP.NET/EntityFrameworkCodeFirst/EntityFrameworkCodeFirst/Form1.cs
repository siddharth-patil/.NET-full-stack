using EntityFrameworkCodeFirst.DataAccess.Model;
using EntityFrameworkCodeFirst.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkCodeFirst
{
    public partial class frm_StudentForm : Form
    {
        StudentService studentService;
        public frm_StudentForm()
        {
            InitializeComponent();
            studentService = new StudentService();
        }

        private void frm_StudentForm_Load(object sender, EventArgs e)
        {
            fetchData();
        }

        void fetchData()
        {
            if (studentService.GetAll().Count > 0)
            {
                dgvStudentDetails.DataSource = studentService.GetAll();
            }
            else
            {
                MessageBox.Show("There is no record in the table!!!");
            }

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (studentService.ManipulateData(new StudentDetails {FirstName = txtFirstname.Text, LastName= txtLastname.Text, Gender = cmbGender.Text, Email= txtEmail.Text, DateofBirth = dtpDob.Value.Date, Qualification= cmbQualification.Text, Percentage = Convert.ToDouble(txtPercentage.Text) },"Add"))
            {
                MessageBox.Show("record added!!!");
                fetchData();
            }
            else
            {
                MessageBox.Show("problem in addition!!!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void dgvStudentDetails_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
