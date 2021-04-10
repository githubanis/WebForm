using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Categories_Electronics_Mobile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
            DropDownList1.SelectedIndex = -1;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write(DropDownList1.SelectedItem.Text + " " + DropDownList1.SelectedItem.Value);
    }
}