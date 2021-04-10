using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Categories_Electronics_Cars : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
        if(ListBox1.SelectionMode.ToString() == "Multiple")
        {
            foreach (ListItem item in ListBox1.Items)
            {
                if (item.Selected)
                {
                    Response.Write(
                        item.Text + " " + 
                        item.Value + " " + 
                        ListBox1.Items.IndexOf(item) + "<br/>");
                }
            }
        }
        else
        {
            Response.Write(ListBox1.SelectedValue + " " + ListBox1.SelectedItem + " " + ListBox1.SelectedIndex);
        }
    }
}