using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Categories_Electronics_CheckBox_ListItem : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        ListBox1.Items.Clear();
        foreach (ListItem item in CheckBoxList1.Items)
        {
            if(item.Selected)
            {
                ListBox1.Items.Add(item.Text);
            }
        }

        if (CheckBoxList1.SelectedIndex == -1)

            Label1.ForeColor = Color.Red;
        else                   
            Label1.ForeColor = Color.Black;

        Label1.Text = ListBox1.Items.Count.ToString() + "item(s) selected.";
    }
}