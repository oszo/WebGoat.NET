using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace OWASP.WebGoat.NET
{
    public partial class HeaderInjection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Headers
            lblHeaders.Text = Request.Headers.ToString().Replace("&", "<br />");;

            //Url Query String
            lblUrlQueryString.Text = "<b>Raw</b> " + Request.QueryString.ToString() + "<br />";
            lblUrlQueryString.Text += "<b>URL decode</b> " + Server.UrlDecode(Request.QueryString.ToString()) + "<br />";
            lblUrlQueryString.Text += "<b>Duble URL decode</b> " + Server.UrlDecode(Server.UrlDecode(Request.QueryString.ToString()));

            //Cookies
            ArrayList colCookies = new ArrayList();
            for (int i = 0; i < Request.Cookies.Count; i++)
                colCookies.Add(Request.Cookies[i]);

            gvCookies.DataSource = colCookies;
            gvCookies.DataBind();
        }
    }
}