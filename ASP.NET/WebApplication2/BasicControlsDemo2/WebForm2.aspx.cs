using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicControlsDemo2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = Convert.ToString(DropDownList1.SelectedValue);

            foreach (ListItem item in DropDownList1.Items)
            {
                if(item.Selected)
                {
                    Label1.Text = item.Text;
                    break;
                }
            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = string.Empty;
            foreach (ListItem item in ListBox1.Items) 
            { 
                if (item.Selected)
                {
                    Label1.Text = Label1.Text + " " + item.Text;
                }
            }

        }
    }
}