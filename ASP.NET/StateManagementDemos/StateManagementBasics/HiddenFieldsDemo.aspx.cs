using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementBasics
{
    public partial class HiddenFieldsDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void HiddenFieldUsername_ValueChanged(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            HiddenFieldUsername.Value = tbUsername.Text;
            HiddenFieldEmail.Value = tbEmail.Text;
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            lblUsernameOp.Text = $"Username:{HiddenFieldUsername.Value}";
            lblPasswordOp.Text = $"Email:{HiddenFieldEmail.Value}";
        }
    }
}