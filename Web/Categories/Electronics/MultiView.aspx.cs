using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Categories_Electronics_MultiView : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        if (Wizard1.ActiveStepIndex == 0)
            TextBox1.Focus();
        if (Wizard1.ActiveStepIndex == 1)
            TextBox2.Focus();
        if (Wizard1.ActiveStepIndex == 2)
            TextBox3.Focus();
    }
}