using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.Cookies["UNAME"] != null && Request.Cookies["PWD"] != null)
            {
                txtUsername.Text = Request.Cookies["UNAME"].Value;
                txtPassword.Attributes["value"] = Request.Cookies["PWD"].Value;
                ChkRememberMe.Checked = true;
            }
        }
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {

        BLLUser user = new BLLUser();

        DataTable dt = user.CheckUserLogin(txtUsername.Text, txtPassword.Text);
        if (dt.Rows.Count != 0)
        {
            Session["USERID"] = dt.Rows[0]["Id"].ToString();
            Session["USEREMAIL"] = dt.Rows[0]["Username"].ToString();

            if (ChkRememberMe.Checked)
            {
                Response.Cookies["UNAME"].Value = txtUsername.Text;
                Response.Cookies["PWD"].Value = txtPassword.Text;

                Response.Cookies["UNAME"].Expires = DateTime.Now.AddDays(15);
                Response.Cookies["PWD"].Expires = DateTime.Now.AddDays(15);
            }
            else
            {
                Response.Cookies["UNAME"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["PWD"].Expires = DateTime.Now.AddDays(-1);
            }
            string Utype;
            Utype = dt.Rows[0][5].ToString().Trim();

            if (Utype == "User" || Utype == "user")
            {
                Session["USERNAME"] = txtUsername.Text;

                Response.Redirect("Home.aspx");
            }
            if (Utype == "Admin" || Utype == "admin")
            {
                Session["AUSERNAME"] = txtUsername.Text;
                Response.Redirect("~/Admin/Dashboard.aspx");
            }
        }
        else
        {
            lblError.Text = "Invalid Username or Password !";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtUsername.Text = "";
        txtPassword.Text = "";
        ChkRememberMe.Checked = false;
    }
}