using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicControlsDemo2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] Books = new string[] { "c#", "asp.net", ".net Core", "mvc", "web api"};
            string[] Sports = new string[] { "cricket", "kho-kho", "chess" };

            string selectedItem = DropDownList1.SelectedValue;

            switch(selectedItem)
            {
                case "Books":
                    CheckBoxList1.DataSource = Books;
                    CheckBoxList1.DataBind();
                    break;
                case "Sports":
                    CheckBoxList1.DataSource = Sports;
                    CheckBoxList1.DataBind();
                    break;
                default:
                    break;
            }
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonDisplayList_Click(object sender, EventArgs e)
        {
            BulletedList1.Items.Clear();
            LabelCategory.Text = string.Empty;
            LabelCategory.Text = $"Your favourite {DropDownList1.SelectedValue} are: ";

            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    BulletedList1.Items.Add(item.Text);
                }
            }
        }
    }
}