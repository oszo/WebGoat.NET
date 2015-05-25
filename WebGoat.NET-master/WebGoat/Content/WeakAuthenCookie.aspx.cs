using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OWASP.WebGoat.NET.Content
{
    public partial class WeakAuthenCookie : System.Web.UI.Page
    {
        static string employeeName = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            labelStatus.Text = "";
            if (Request.Cookies["salary_authen"] != null)
            {
                labelName.Text = "Hi, " + employeeName;
            }
        }

        public void btnLogin_Click(object sender, EventArgs e) 
        {
            employeeName = txtBoxUsername.Text;
            string emName = txtBoxUsername.Text.ToLower();
            string emPass = txtBoxPassword.Text.ToLower();
            if (emName.Length != 0 && emPass.Length != 0)
            {
                if (((emName == "alice") && (emPass == "ali")) || ((emName == "morgan") && (emPass == "mor")) || ((emName == "john") && (emPass == "manag3rj0hn")))
                {
                    HttpCookie cookie = new HttpCookie("salary_authen");
                    cookie.Value = emName + "_authen";
                    Response.Cookies.Add(cookie);
                    labelName.Text = "Hi, " + employeeName;
                }
                else
                {
                    labelStatus.Text = "Default password is 3 Digit of employee name.";
                }
            }
            else
            {
                labelStatus.Text = "Employee name or Password are empty!";
            }
        }

        public void btnLogout_Click(object sender, EventArgs e) 
        {
            Response.Cookies["salary_authen"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect(Request.Url.ToString());
        }

        public void btnEm1_Click(object sender, EventArgs e) 
        {
            if (Request.Cookies["salary_authen"] != null)
            {
                if (Request.Cookies["salary_authen"].Value == "john_authen")
                {
                    labelEmInfo.Text = "ID: 001<br/>";
                    labelEmInfo.Text += "Name: John Wickh<br/>";
                    labelEmInfo.Text += "salary: 1,500 $<br/>";
                }
                else
                {
                    labelStatus.Text = "Permission denied, You do not have permission to access the infomation.";
                }
            }
            else
            {
                labelStatus.Text = "Permission denied, You do not have permission to access the infomation.";
            }
        }

        public void btnEm2_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["salary_authen"] != null)
            {
                if ((Request.Cookies["salary_authen"].Value == "john_authen") || (Request.Cookies["salary_authen"].Value == "alice_authen"))
                {
                    labelEmInfo.Text = "ID: 002<br/>";
                    labelEmInfo.Text += "Name: Alice Eve<br/>";
                    labelEmInfo.Text += "salary: 900 $<br/>";
                }
                else
                {
                    labelStatus.Text = "Permission denied, You do not have permission to access the infomation.";
                }
            }
            else
            {
                labelStatus.Text = "Permission denied, You do not have permission to access the infomation.";
            }
        }

        public void btnEm3_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["salary_authen"] != null)
            {
                if ((Request.Cookies["salary_authen"].Value == "john_authen") || (Request.Cookies["salary_authen"].Value == "morgan_authen"))
                {
                    labelEmInfo.Text = "ID: 003<br/>";
                    labelEmInfo.Text += "Name: Morgan freeman<br/>";
                    labelEmInfo.Text += "salary: 1,100 $<br/>";
                }
                else
                {
                    labelStatus.Text = "Permission denied, You do not have permission to access the infomation.";
                }
            }
            else
            {
                labelStatus.Text = "Permission denied, You do not have permission to access the infomation.";
            }
        }

    }
}