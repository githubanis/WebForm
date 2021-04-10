using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Categories_Electronics_FileUpload : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnUpload_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            var fileExtension = Path.GetExtension(FileUpload1.FileName);

            if(fileExtension.ToLower() == ".doc" || fileExtension.ToLower() == ".docx")
            {
                int fileSize = FileUpload1.PostedFile.ContentLength;
                if (fileSize <= 2097152)
                {
                    FileUpload1.SaveAs(Server.MapPath("~/Uploads/" + FileUpload1.FileName));
                    lblMessage.Text = "File Uploaded!";
                    lblMessage.ForeColor = Color.Green;
                }
                else
                {
                    lblMessage.Text = "Max file size 2Mb";
                    lblMessage.ForeColor = Color.Blue;
                }
            }
            else
            {
                lblMessage.Text = "Please Select a DOC file";
                lblMessage.ForeColor = Color.Blue;
            }
            
        }
        else
        {
            lblMessage.Text = "Please Select a file to upload";
            lblMessage.ForeColor = Color.Red;
        }
    }
}