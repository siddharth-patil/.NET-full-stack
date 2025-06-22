using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementBasics
{
    public partial class ApplicationDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Application["Username"] = tbUsername.Text;
            Application["Email"] = tbEmail.Text;

            Response.Redirect("~/ApplicationResult.aspx");
        }
    }
}