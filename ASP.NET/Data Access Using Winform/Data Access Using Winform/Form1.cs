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
    public partial class frm_EmpDataAccess : Form
    {
        EmployeeOperations obj_ref;
        //EmployeeOperationsNew newObj_ref;
        public frm_EmpDataAccess()
        {
            InitializeComponent();
            obj_ref = new EmployeeOperations();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        void SelectAll()
        {
            List<Employee> employees = obj_ref.GetAllEmployees();

            if (employees.Count > 0)
            {
                dataGridViewEmpData.DataSource = employees;

                listBoxOutput.DataSource = employees;
            }
        }

        void PopulateData()
        {
            comboBoxGender.Items.Add("Male");
            comboBoxGender.Items.Add("Female");
        }

        private void frm_EmpDataAccess_Load(object sender, EventArgs e)
        {
            PopulateData();
            SelectAll();
        }

        void ClearData()
        {
            txtName.Text = txtSalary.Text = string.Empty;
            comboBoxGender.Items.Clear();
            dateTimePicker1.Value = dateTimePicker1.MinDate;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if(obj_ref.AddEmployee(new Employee { Name=txtName.Text, DateOfJoining = dateTimePicker1.Value.ToShortDateString(), Gender=comboBoxGender.Text, Salary= Convert.ToDouble(txtSalary.Text) }))
                if (obj_ref.AddEmployeeWithStoredProcedure(new Employee { Name = txtName.Text, DateOfJoining = dateTimePicker1.Value.ToShortDateString(), Gender = comboBoxGender.Text, Salary = Convert.ToDouble(txtSalary.Text) }))
                {
                MessageBox.Show("New employee added successfully...!");
                ClearData();
                SelectAll();
            }
            else
            {
                MessageBox.Show("Problem in adding new employee.");
            }
        }

        int empId = -1;
        private void dataGridViewEmpData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //e.RowIndex = e.e.RowIndex;
            //MessageBox.Show(" " + e.RowIndex);
            empId = Convert.ToInt32(dataGridViewEmpData.Rows[e.RowIndex].Cells["Id"].Value);
            txtName.Text = dataGridViewEmpData.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            comboBoxGender.Text = dataGridViewEmpData.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridViewEmpData.Rows[e.RowIndex].Cells["DateOfJoining"].Value);
            txtSalary.Text = dataGridViewEmpData.Rows[e.RowIndex].Cells["Salary"].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool sts = obj_ref.UpdateEmployee(new Employee { Id = empId, Name=txtName.Text, Gender = comboBoxGender.Text, DateOfJoining = dateTimePicker1.Value.ToShortDateString(), Salary = Convert.ToDouble(txtSalary.Text)});

            if (sts)
            {
                MessageBox.Show("New employee Updated successfully...!");
                ClearData();
                SelectAll();
            }
            else
            {
                MessageBox.Show("Problem in updating employee.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool dltSts = obj_ref.DeleteEmployee(empId);
            if (dltSts) 
            {
                MessageBox.Show("Employee record deleted successfully...!");
                ClearData();
                SelectAll();
            }
            else
            {
                MessageBox.Show("Problem in deleting employee record.");
            }
        }
    }
}
