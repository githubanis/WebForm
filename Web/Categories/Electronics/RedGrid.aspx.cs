using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Telerik.Web.UI;
 
namespace Telerik.GridExamplesCSharp.DataBinding.SimpleVsAdvanced
{
    public partial class DefaultCS : System.Web.UI.Page
    {
        public void Page_Load(object sender, System.EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDataForRadGrid1();
            }
        }
 
        protected void RadGrid1_PageSizeChanged(object sender, GridPageSizeChangedEventArgs e)
        {
            LoadDataForRadGrid1();
        }
 
        protected void RadGrid1_PageIndexChanged(object sender, Telerik.Web.UI.GridPageChangedEventArgs e)
        {
            LoadDataForRadGrid1();
        }
 
        protected void RadGrid1_SortCommand(object sender, Telerik.Web.UI.GridSortCommandEventArgs e)
        {
            LoadDataForRadGrid1();
        }
 
        private void LoadDataForRadGrid1()
        {
            RadGrid1.DataSource = GetDataTable();
        }
 
        protected void RadGrid2_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            (sender as RadGrid).DataSource = GetDataTable();
        }
 
        public DataTable GetDataTable()
        {
            string query = "SELECT Id, Name, Department, Age, Gender, DateOfBirth FROM Student order by Name";
 
            String ConnString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(ConnString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(query, conn);
 
            DataTable myDataTable = new DataTable();
 
            conn.Open();
            try
            {
                adapter.Fill(myDataTable);
            }
            finally
            {
                conn.Close();
            }
 
            return myDataTable;
        }
    }
}