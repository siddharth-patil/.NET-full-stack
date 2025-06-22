using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementBasics
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        string username = "", email = "";
 
        protected void btnShow_Click(object sender, EventArgs e)
        {
            //lblUsernameOp.Text = $"Username:{username}";
            //lblPasswordOp.Text = $"Email:{email}";

            lblUsernameOp.Text = $"Username:{ViewState["Username"]}";
            lblPasswordOp.Text = $"Email:{ViewState["Email"]}";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            username = tbUsername.Text;
            email = tbEmail.Text;

            ViewState["Username"] = username;
            ViewState["Email"]= email;
        }
    }
}