using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementBasics
{
    public partial class SessionResult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {

                if (Session["Username"] != null && Session["Email"] != null)
                {
                    lblUsernameOp.Text = Session["Username"].ToString();
                    lblPasswordOp.Text = Session["Email"].ToString();
                }
                else {
                    lblUsernameOp.Text = "Session doesn't have any values.";
                }
                
            }
        }
    }
}