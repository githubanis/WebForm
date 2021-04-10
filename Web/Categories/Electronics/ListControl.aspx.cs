using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Categories_Electronics_ListControl : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ListControl(5);
        }
    }

    private void ListControl(int s)
    {
        PopulateItem(DropDownList1, s);
        PopulateItem(CheckBoxList1, s);
        PopulateItem(RadioButtonList1, s);
        PopulateItem(ListBox1, s);
        PopulateItem(BulletedList1, s);
    }

    private void PopulateItem(ListControl listControl, int size)
    {        
        for (int i = 0; i < size; i++)
        {
            ListItem l = new ListItem("Item", "1");
            listControl.Items.Add(l);
        }

    }

    private void GetMultipleSelection(ListControl listControl)
    {
        foreach (ListItem item in listControl.Items)
        {

        }
    }
}