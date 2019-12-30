using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_ResetPassword : System.Web.UI.Page
{
    BLLUser user = new BLLUser();
    String GUIDvalue;
    int Uid;
    protected void Page_Load(object sender, EventArgs e)
    {
        //GUIDvalue = Request.QueryString["Uid"];
        //try
        //{
        //    if (GUIDvalue != null)
        //    {
        //        DataTable dt = user.GetForgotPasswordGUID(GUIDvalue);
        //        if (dt.Rows.Count != 0)
        //        {
        //            Uid = Convert.ToInt32(dt.Rows[0][1]);
        //        }
        //        else
        //        {
        //            lblMsg.Text = "Your Password Reset Link is Expired or Invalid !";
        //            lblMsg.ForeColor = Color.Red;
        //        }
        //    }
        //    else
        //    {
        //        Response.Redirect("~/Default.aspx");
        //    }
        //}
        //catch (Exception ex)
        //{
        //    throw (ex);
        //}


    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        //try
        //{
        //    if (txtPassword.Text == null || txtConfirmPassword.Text == null)
        //    {
        //        lblMsg.Text = "All fields are required.";
        //    }
        //    else if (txtPassword.Text != txtConfirmPassword.Text)
        //    {
        //        lblMsg.Text = "Password Mismatch";
        //    }
        //    else
        //    {
        //        int i = user.UpdatePassword(txtPassword.Text, Uid);
        //        if (i > 0)
        //        {
        //            lblMsg.Text = "Password reset successfully.";
        //        }
        //        else
        //        {
        //            lblMsg.Text = "Reset Password Failed.";
        //        }

        //        txtPassword.Text = string.Empty;
        //        txtConfirmPassword.Text = string.Empty;
        //    }
        //}
        //catch (Exception ex)
        //{
        //    throw (ex);
        //}

    }


}