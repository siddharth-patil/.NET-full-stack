using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementBasics
{
    public partial class CookiesDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("UserInfo");

            cookie["Username"] = tbUsername.Text;
            cookie["Email"] = tbEmail.Text;

            cookie.Expires = DateTime.Now.AddSeconds(45);

            Response.Cookies.Add(cookie);
            Response.Redirect("~/Result.aspx");
        }
    }
}