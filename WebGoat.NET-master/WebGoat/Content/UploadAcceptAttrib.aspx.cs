using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace OWASP.WebGoat.NET.Content
{
    public partial class UploadAcceptAttrib : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUploadClick(object sender, EventArgs e)
        {
            HttpPostedFile file = Request.Files["uploadedFile"];

            //check file was submitted
            if (file != null && file.ContentLength > 0)
            {
                try
                {
                    string filename = Path.GetFileName(file.FileName);
                    file.SaveAs(Server.MapPath("~/WebGoatCoins/uploads/") + filename);
                    labelUpload.Text = "<div class='success' style='text-align:center'>The file " + file.FileName + " has been saved in to the WebGoatCoins/uploads directory</div>";
                }
                catch (Exception ex)
                {
                    labelUpload.Text = "<div class='error' style='text-align:center'>Upload Failed: " + ex.Message + "</div>";
                }
                finally
                {
                    labelUpload.Visible = true;
                }
            }
        }
    }
}