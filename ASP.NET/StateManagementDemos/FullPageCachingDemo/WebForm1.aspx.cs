﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FullPageCachingDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblOption.Text = DropDownList1.SelectedValue;
        }
    }
}