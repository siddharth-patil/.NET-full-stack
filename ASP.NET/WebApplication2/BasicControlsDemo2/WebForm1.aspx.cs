using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicControlsDemo2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string TextToEncode = "<b>This is lable<b/>";
            //string EncodedText = Server.HtmlEncode(TextToEncode);
            //Label2.Text = EncodedText;

            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = "Button is clicked!!!";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string virtualPath = "~\\uploadImages";
            string physicalPath = Server.MapPath(virtualPath);

            FileUpload1.SaveAs($"{physicalPath}\\{FileUpload1.FileName}");
        }
    }
}