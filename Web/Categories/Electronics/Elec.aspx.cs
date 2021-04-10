using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Categories_Electronics_Elec : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            dContinent.DataSource =  GetData("pContinent", null);
            dContinent.DataBind();

            var liContinent = new ListItem("Select Continent", "-1");
            dContinent.Items.Insert(0, liContinent);

            var liCountry = new ListItem("Select Country", "-1");
            dCountry.Items.Insert(0, liCountry);

            var liCity = new ListItem("Select City", "-1");
            dCity.Items.Insert(0, liCity);

            dCountry.Enabled = false;
            dCity.Enabled = false;
        }
    }

    private DataSet GetData(string SpName, SqlParameter SPPerams)
    {
        string cs = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        var con = new SqlConnection(cs);
        var da = new SqlDataAdapter(SpName, con);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        if(SPPerams != null)
        {
            da.SelectCommand.Parameters.Add(SPPerams);
        }

        var ds = new DataSet();
        da.Fill(ds);

        return ds;
    }

    protected void dContinent_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Write("Continent Selected");
        if (dContinent.SelectedIndex == 0)
        {
            dCountry.SelectedIndex = 0;
            dCountry.Enabled = false;

            dCity.SelectedIndex = 0;
            dCity.Enabled = false;
        }
        else
        {
            dCountry.Enabled = true;
            SqlParameter sqlParameter = new SqlParameter("@continentId", dContinent.SelectedValue);
            DataSet ds = GetData("pCountry", sqlParameter);

            dCountry.DataSource = ds;
            dCountry.DataBind();

            var liCountry = new ListItem("Select Country", "-1");
            dCountry.Items.Insert(0, liCountry);

            dCity.SelectedIndex = 0;
            dCity.Enabled = false;
        }
    }

    protected void dCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (dCountry.SelectedIndex == 0)
        {

        }
        else
        {
            dCity.Enabled = true;
            SqlParameter sqlParameter = new SqlParameter("@contryId", dCountry.SelectedValue);
            DataSet ds = GetData("pCity", sqlParameter);

            dCity.DataSource = ds;
            dCity.DataBind();

            var liCity = new ListItem("Select City", "-1");
            dCity.Items.Insert(0, liCity);
        }
    }

    protected void dCity_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    
}