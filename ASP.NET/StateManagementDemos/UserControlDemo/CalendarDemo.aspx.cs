using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserControlDemo
{
    public partial class CalendarDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void getDate_Click(object sender, EventArgs e)
        {
            // 1.Use public property
            //lblDate.Text = CalendarUserControl1.CalendarDate;

            //2. Use FindControl() method
            TextBox UserControlTextBx = (TextBox) CalendarUserControl1.FindControl("txtDate");

            lblDate.Text = UserControlTextBx.Text == ""?"Date is not selected from calendar" : UserControlTextBx.Text;
        }
    }
}