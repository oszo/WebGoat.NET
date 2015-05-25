using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OWASP.WebGoat.NET
{
    public partial class CSRFDemo : System.Web.UI.Page
    {
        static string salaryDetail = "";
        public class StructData
        {
            public string emId;
            public string emName;
            public int emSalary;
        }
        static StructData[] datas = new StructData[3];

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["salary_manage"] == null)// init
            {
                HttpCookie cookie = new HttpCookie("salary_manage");
                cookie.Value = "set";
                Response.Cookies.Add(cookie);
                for (int i = 0; i < datas.Length; i++)
                {
                    datas[i] = new StructData();
                    if (i == 0)
                    {
                        datas[i].emId = "001";
                        datas[i].emName = "John";
                        datas[i].emSalary = 1500;
                    }
                    else if (i == 1)
                    {
                        datas[i].emId = "002";
                        datas[i].emName = "Alice";
                        datas[i].emSalary = 900;
                    }
                    else if (i == 2)
                    {
                        datas[i].emId = "003";
                        datas[i].emName = "Morgan";
                        datas[i].emSalary = 1100;
                    }
                }
            }
            if (datas[0] == null)
            {
                HttpCookie cookie = new HttpCookie("salary_manage");
                cookie.Value = "set";
                Response.Cookies.Add(cookie);
                for (int i = 0; i < datas.Length; i++)
                {
                    datas[i] = new StructData();
                    if (i == 0)
                    {
                        datas[i].emId = "001";
                        datas[i].emName = "John";
                        datas[i].emSalary = 1500;
                    }
                    else if (i == 1)
                    {
                        datas[i].emId = "002";
                        datas[i].emName = "Alice";
                        datas[i].emSalary = 900;
                    }
                    else if (i == 2)
                    {
                        datas[i].emId = "003";
                        datas[i].emName = "Morgan";
                        datas[i].emSalary = 1100;
                    }
                }
            }
            if ((Request.QueryString["ctl00$BodyContentPlaceholder$emId"] != null) && (Request.QueryString["ctl00$BodyContentPlaceholder$slIncrease"] != null))
            {
                int salary_index = 0;
                if (Request.QueryString["ctl00$BodyContentPlaceholder$emId"] == "001")
                {
                    salary_index = 0;
                }
                else if (Request.QueryString["ctl00$BodyContentPlaceholder$emId"] == "002")
                {
                    salary_index = 1;
                }
                else if (Request.QueryString["ctl00$BodyContentPlaceholder$emId"] == "003")
                {
                    salary_index = 2;
                }
                int oldSalary = datas[salary_index].emSalary;
                int newSalary = oldSalary + Int32.Parse(Request.QueryString["ctl00$BodyContentPlaceholder$slIncrease"]);
                datas[salary_index].emSalary = newSalary;
            }

            salaryDetail = "";
            for (int i = 0; i < datas.Length; i++)
            {
                salaryDetail += "<p>";
                salaryDetail += "Employee ID: " + datas[i].emId + "<br />";
                salaryDetail += "Employee Name: " + datas[i].emName + "<br />";
                salaryDetail += "Salary: " + datas[i].emSalary.ToString() + "<br />";
                salaryDetail += "</p>";
            }
            labelStatus.Text = salaryDetail;
        }

        public void btnReset_Click(object sender, EventArgs e)
        {
            Response.Cookies["salary_manage"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect(Request.Url.ToString());
        }

        public void buttonIncrease_Click(object sender, EventArgs e)
        {
            if ((emId.Text.Length != 0) && (slIncrease.Text.Length != 0))
            {
                int salary_index = 0;
                if (emId.Text == "001")
                {
                    salary_index = 0;
                }
                else if (emId.Text == "002")
                {
                    salary_index = 1;
                }
                else if (emId.Text == "003")
                {
                    salary_index = 2;
                }
                int oldSalary = datas[salary_index].emSalary;
                int newSalary = oldSalary + Int32.Parse(slIncrease.Text);
                datas[salary_index].emSalary = newSalary;
                Response.Redirect(Request.Url.ToString());
            }
        }
    }
}