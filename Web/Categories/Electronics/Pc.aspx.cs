using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Categories_Electronics_Pc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
            CheckBoxList1.SelectedIndex = 1;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        foreach (ListItem item in CheckBoxList1.Items)
        {
            if(item.Selected)
            {
                Response.Write("Text = " + item.Text + ", ");
                Response.Write("Value = " + item.Value + ", ");
                Response.Write("Index = " + CheckBoxList1.Items.IndexOf(item) + "<br/>");
            }
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        foreach (ListItem item in CheckBoxList1.Items)
            item.Selected = true;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        foreach (ListItem item in CheckBoxList1.Items)
            item.Selected = false;
    }
}