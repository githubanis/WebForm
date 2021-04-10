using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Categories_Electronics_Radio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write(
            RadioButtonList1.SelectedItem + " " + 
            RadioButtonList1.SelectedValue + " " + 
            RadioButtonList1.SelectedIndex);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        RadioButtonList1.SelectedIndex = -1;
    }
}