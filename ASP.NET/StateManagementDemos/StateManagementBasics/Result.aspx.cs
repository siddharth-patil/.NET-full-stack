using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementBasics
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //------->For query string
            //lblUsernameOp.Text = $"{Request.QueryString["Username"]}";
            //lblPasswordOp.Text = $"{Request.QueryString["Email"]}";

            //------>For cookies

            //if (!IsPostBack)
            //{
            //    var Cookie = Request.Cookies["UserInfo"];

            //    if (Cookie != null)
            //    {
            //        lblUsernameOp.Text = Cookie["Username"];
            //        lblPasswordOp.Text = Cookie["Email"];
            //    }
            //    else
            //    {
            //        lblUsernameOp.Text = "Cookie doesn't contain any value...";
            //    }
            //}


            //------> For Cross page postback

            if (!IsPostBack)
            {
                if (Page.PreviousPage != null)
                {
                    TextBox tBoxUsername = (TextBox)Page.PreviousPage.FindControl("tbUsername");
                    TextBox tBoxEmail = (TextBox)Page.PreviousPage.FindControl("tbEmail");

                    lblUsernameOp.Text = tBoxUsername.Text;
                    lblPasswordOp.Text = tBoxEmail.Text;
                }
            }


        }
    }
}