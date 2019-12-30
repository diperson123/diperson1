using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_UserFeedback : System.Web.UI.Page
{
    BLLEnquiry feedback = new BLLEnquiry();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btncontactus_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtUsername.Text != null && txtEmail.Text != null && txtmessage.Text != null)
            {

                int i = feedback.CreateEnquiry(txtUsername.Text, txtEmail.Text, txtmessage.Text);
                if (i > 0)
                {
                    Response.Redirect("~/user/home.aspx");

                }
            }


            else
            {
                ltrmsg.Text = "All fields are mandatory.";
            }
        }
        catch (Exception ex)
        {

            throw (ex);
        }
    }
}