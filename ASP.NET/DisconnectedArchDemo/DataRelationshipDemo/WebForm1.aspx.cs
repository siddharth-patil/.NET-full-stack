using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace DataRelationshipDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection sqlcon;
        SqlCommand sqlcmd;
        SqlDataReader sqldr;

        public WebForm1()
        {
            sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["ADODBConnectionString"].ConnectionString);
        }

        void populateData()
        {
            sqlcmd = new SqlCommand("select Id, Name from Branch", sqlcon);

            try
            {
                sqlcon.Open();
                sqldr = sqlcmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqldr);

                //DropDownList1.DataSource = dt.Columns["Name"];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DropDownList1.Items.Add((string)dt.Rows[i]["Name"]);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                sqlcon.Close();
            }
            
        }

        void filterData(string BranchName)
        {
            sqlcmd = new SqlCommand("select StudentNew.Roll, StudentNew.Name, StudentNew.Marks, Branch.Name from Branch join StudentNew on Branch.Id = StudentNew.Branch_Id where Branch.Name = @BranchName",sqlcon);
            sqlcmd.Parameters.AddWithValue("@BranchName", BranchName);
            try
            {
                sqlcon.Open();
                sqldr = sqlcmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqldr);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch (Exception)
            {

            }
            finally
            {
                sqlcon.Close();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                populateData();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterData(DropDownList1.Text);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }
    }
}