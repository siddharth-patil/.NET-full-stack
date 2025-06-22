using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementBasics
{
    public partial class CacheResult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                lblUsername.Text = Cache["Username"].ToString();
                lblEmail.Text = (string)Cache["Email"];
            }
            
        }
    }
}