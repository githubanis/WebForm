using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Categories_Electronics_BulettedListt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
    {
        ListItem li = BulletedList1.Items[e.Index];

        Response.Write(li.Text + " " + li.Value + " " + e.Index.ToString());
    }
}