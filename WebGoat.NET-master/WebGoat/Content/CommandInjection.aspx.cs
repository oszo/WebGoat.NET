using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Diagnostics;
using System.Net;

namespace OWASP.WebGoat.NET
{
    public partial class CommandInjection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void btnCmdi_Click(object sender, EventArgs e) {
            string outputs = "";

            //System.Diagnostics.Process process = new System.Diagnostics.Process();
            //System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            //startInfo.FileName = "cmd.exe";
            //startInfo.Arguments = "dir";
            //process.StartInfo = startInfo;
            //process.Start();

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe" ;
            process.StartInfo.Arguments = "/c ping " + txtBoxMsgCmdi.Text;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();

            StreamReader reader = process.StandardOutput;
            string output = reader.ReadToEnd();

            outputs += output;

            process.WaitForExit();
            process.Close();

            lblResultCmdi.Text = WebUtility.HtmlEncode(outputs).Replace("\r\n", "<br/>");
        }
    }
}