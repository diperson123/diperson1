using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_SignUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        if (txtUsername.Text != "" && txtPhone.Text != "" && txtEmail.Text != "" && txtPassword.Text != "" && txtConfirmPassword.Text != "")
        {
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                BLLUser user = new BLLUser();
                int i = user.CreateUser(txtUsername.Text, txtPhone.Text, txtEmail.Text, txtPassword.Text, "User");
                if (i > 0)
                {
                    lblMsg.Text = "Successfully registered.Thank you for the registration.";
                    lblMsg.ForeColor = Color.Green;
                    clear();
                    Response.Redirect("~/User/Login.aspx");

                }
                else
                {
                    lblMsg.ForeColor = Color.Red;
                    lblMsg.Text = "Failed to register";
                }
            }
            else
            {
                lblMsg.ForeColor = Color.Red;
                lblMsg.Text = "Passwords do not match";
            }
        }
        else
        {
            lblMsg.ForeColor = Color.Red;
            lblMsg.Text = "All Fields Are Mandatory";

        }
    }

    private void clear()
    {
        txtUsername.Text = string.Empty;
        txtPhone.Text = string.Empty;
        txtEmail.Text = string.Empty;
        txtPassword.Text = string.Empty;
        txtConfirmPassword.Text = string.Empty;
    }
}
