using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace OWASP.WebGoat.NET
{
    public partial class UploadPathManipulation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PMbtnUpload_Click(object sender, EventArgs e)
        {
            if (PMFileUpload1.HasFile)
            {
                //try
                //{
                //    string filename = Path.GetFileName(PMFileUpload1.FileName);
                //    PMFileUpload1.SaveAs(Server.MapPath("~/WebGoatCoins/uploads/") + filename);
                //    labelPMUpload.Text = "<div class='success' style='text-align:center'>The file " + PMFileUpload1.FileName + " has been saved in to the WebGoatCoins/uploads directory</div>";
                    
                //}
                //catch (Exception ex)
                //{
                //    labelPMUpload.Text = "<div class='error' style='text-align:center'>Upload Failed: " + ex.Message + "</div>";
                //}
                //finally
                //{
                //    labelPMUpload.Visible = true;
                //}
                string fileExt = System.IO.Path.GetExtension(PMFileUpload1.FileName);
                if (fileExt == ".pdf" || fileExt == ".xls" || fileExt == ".xlm" || fileExt == ".xlsx" || fileExt == ".xlsm" || fileExt == ".txt")
                {
                    try
                    {
                        string filename = Path.GetFileName(PMFileUpload1.FileName);
                        PMFileUpload1.SaveAs(Server.MapPath("~/WebGoatCoins/uploads/") + filename);
                        labelPMUpload.Text = "<div class='success' style='text-align:center'>The file " + PMFileUpload1.FileName + " has been saved in to the WebGoatCoins/uploads directory</div>";

                    }
                    catch (Exception ex)
                    {
                        labelPMUpload.Text = "<div class='error' style='text-align:center'>Upload Failed: " + ex.Message + "</div>";
                    }
                    finally
                    {
                        labelPMUpload.Visible = true;
                    }
                }
                else 
                {
                    labelPMUpload.Text = "<div class='error' style='text-align:center'>Upload Failed: Only PDF, Excel or Plain Text files allowed!(" + fileExt + ")</div>";
                    labelPMUpload.Visible = true;
                }
            }
        }
    }
}