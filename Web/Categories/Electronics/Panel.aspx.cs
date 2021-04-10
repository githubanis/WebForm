using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Categories_Electronics_Panel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void gbtn_Click(object sender, EventArgs e)
    {
        var data = htxt.Text;
        Response.Write(data);
        int count = Convert.ToInt32(data);

        foreach (ListItem li in CheckBoxList1.Items)
        {
            if(li.Selected)
            {
                if (li.Value == "lbl")
                {
                    for (int i = 1; i <= count; i++)
                    {
                        var l = new Label();
                        l.Text = "Label" + i.ToString();
                        panelLbl.Controls.Add(l);
                    }
                }
                else if (li.Value == "txt")
                {
                    for (int i = 1; i <= count; i++)
                    {
                        var l = new TextBox();
                        l.Text = "TextBox" + i.ToString();
                        panelTxt.Controls.Add(l);
                    }
                }
                else
                {
                    for (int i = 1; i <= count; i++)
                    {
                        var l = new Button();
                        l.Text = "Button" + i.ToString();
                        panelBtn.Controls.Add(l);
                    }
                }
            }
        }
    }
}