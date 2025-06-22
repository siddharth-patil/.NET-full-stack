using Data_Access_Using_Winform.Data_Access;
using Data_Access_Using_Winform.Data_Access.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Access_Using_Winform
{
    public partial class CRUDoperationsWithSingleProcedure : Form
    {
        EmployeeOperationsNew obj_ref;
        public CRUDoperationsWithSingleProcedure()
        {
            InitializeComponent();
            obj_ref = new EmployeeOperationsNew();
        }

        void PopulateGender()
        {
            comboBoxGender.Items.Add("Male");
            comboBoxGender.Items.Add("Female");
        }

        void SelectAll()
        {
            List<Employee> res = obj_ref.GetAll();
            dataGridViewEmpData.DataSource = res;
            listBoxOutput.DataSource = res;
        }
        void ClearData()
        {
            txtName.Text = txtSalary.Text = string.Empty;
            comboBoxGender.Items.Clear();
            dateTimePicker1.Value = dateTimePicker1.MinDate;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(obj_ref.ManipulateEmployee(new Employee { Name=txtName.Text, Gender=comboBoxGender.Text, DateOfJoining=dateTimePicker1.Value.ToLongDateString(), Salary=Convert.ToDouble(txtSalary.Text) },"Add"))
            {
                MessageBox.Show("Data added successfully!!");
                ClearData();
                SelectAll();
            }
            else
            {
                MessageBox.Show("Problem in adding Data!!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CRUDoperationsWithSingleProcedure_Load(object sender, EventArgs e)
        {
            PopulateGender();
            SelectAll();
            //ClearData();
        }
    }
}
