using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Categories_Electronics_Submit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void cancel_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
    }


    protected void submit_Click(object sender, EventArgs e)
    {
        msg.Text = "You entered: " + TextBox1.Text;
    }
}