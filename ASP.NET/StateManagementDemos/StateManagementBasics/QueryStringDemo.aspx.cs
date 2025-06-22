using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementBasics
{
    public partial class QueryStringDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Response.Redirect("https://www.google.com");

            //string queryString = $"~/Result.aspx?Username={tbUsername.Text}&Email={tbEmail.Text}";
            //string queryString = $"~/Result.aspx?Username={Server.UrlEncode(tbUsername.Text)}&Email={Server.UrlEncode(tbEmail.Text)}";

            string queryString = $"~/Result.aspx?Username={tbUsername.Text.Replace("&","%26")}&Email={tbEmail.Text.Replace("&", "%26")}";

            Response.Redirect(queryString);
        }
    }
}