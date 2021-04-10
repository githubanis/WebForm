using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Categories_Electronics_GridView : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            BindDataToGridView();
    }

    public void BindDataToGridView()
    {
        var cfc = WebConfigurationManager.ConnectionStrings["DefaultConnection"];

        using (SqlConnection dbCon = new SqlConnection(cfc.ConnectionString))
        {
            try
            {
                dbCon.Open();
                SqlCommand cmd = new SqlCommand("Select colorId, name, hex from Color order by colorId", dbCon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if(ds.Tables[0].Rows.Count > 0)
                {
                    GridView1.DataSource = ds;
                    GridView1.DataBind();
                }
            }
            catch(SqlException ex)
            {
                ltError.Text = "Error" + ex.Message;
            }
            finally
            {
                dbCon.Close();
                dbCon.Dispose();
            }
        }
    }

    protected void btnAddRow_Click(object sender, EventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}