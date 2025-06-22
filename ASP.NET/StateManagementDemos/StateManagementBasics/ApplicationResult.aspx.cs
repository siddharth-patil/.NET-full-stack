using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementBasics
{
    public partial class ApplicationResult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                lblUsernameOp.Text = Application["Username"].ToString();
                lblPasswordOp.Text = Application["Email"].ToString();
            }
        }
    }
}