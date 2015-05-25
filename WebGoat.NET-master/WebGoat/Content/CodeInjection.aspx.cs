using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OWASP.WebGoat.NET.Content
{
    public partial class CodeInjection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void btnCi_Click(object sender, EventArgs e)
        {
            //string header = "<% lblTest.Text =\"" + txtBoxMsgCi.Text + "\";%>";
            string header = "<% lblTest.Text =\"" + Server.HtmlEncode(txtBoxMsgCi.Text) + "\";%>";
            string body = "<html xmlns=\"http://www.w3.org/1999/xhtml\" ><head runat=\"server\"></head><body><h1>Share Space.</h1><br /><asp:Label runat=\"server\" id=\"lblTest\"></asp:Label></body></html>";
            System.IO.File.WriteAllText(Server.MapPath("~/share_article/") + "page.aspx", header + body);
        }

    }
}