using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_ForgotPassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnForgotPassword_Click(object sender, EventArgs e)
    {
        //BLLUser user = new BLLUser();
        //try
        //{
        //    if (txtForgotPassword.Text != null)
        //    {
        //        DataTable dt = user.CheckEmail(txtForgotPassword.Text);
        //        if (dt.Rows.Count  != 0)
        //        {
        //            String myGUID = Guid.NewGuid().ToString();
        //            int Uid = Convert.ToInt32(dt.Rows[0][0]);
        //            //DateTime date = DateTime.Today;
        //            int i = user.SaveForgotPasswordGUID(myGUID, Uid);
        //            //send email
        //            String ToEmailAddress = dt.Rows[0][4].ToString();
        //            String Username = dt.Rows[0][6].ToString();
        //            String EmailBody = "Hi " + Username + ",<br/><br/> Click the link below to reset your password <br/><br/> http://localhost:4701/User/ResetPassword.aspx?Uid=" + myGUID;
        //            MailMessage PassRecMail = new MailMessage("goldenfriedchicken132@gmail.com", ToEmailAddress);
        //            PassRecMail.Body = EmailBody;
        //            PassRecMail.IsBodyHtml = true;
        //            PassRecMail.Subject = "Reset Password";

        //            //SmtpClient SMTP = new SmtpClient("smtp-mail.outlook.com", 587);
        //            SmtpClient SMTP = new SmtpClient("smtp.gmail.com", 587);
        //            SMTP.Credentials = new NetworkCredential()
        //            {
        //                UserName = "goldenfriedchicken132@gmail.com",
        //                Password = "admin@1admin"
        //            };
        //            SMTP.EnableSsl = true;
        //            SMTP.Send(PassRecMail);
        //            lblMsg.Text = "Please check your email to reset the password";
        //        }
        //        else {
        //            lblMsg.Text = "This email is not registered to this account";
        //        }
        //    }
        //}
        //catch (Exception ex)
        //{
        //    throw (ex);
        //}
    }
}