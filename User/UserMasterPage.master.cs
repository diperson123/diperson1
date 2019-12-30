using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_UserMasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BLLCart cart = new BLLCart();
        if (Session["USERID"] != null)
        {
            int userId = Convert.ToInt32(Session["USERID"]);
            btnSignOut.Visible = true;
            btnSignIn.Visible = false;
            DataTable dt = cart.GetAllCartItems(userId);
            itemQuantity.Text = dt.Rows.Count.ToString();
        }
        else
        {
            btnSignOut.Visible = false;
            btnSignIn.Visible = true;
        }
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session["USERID"] = null;
        Session["USERNAME"] = null;
        Response.Redirect("~/User/Home.aspx");
    }

    protected void btnSignIn_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/User/Login.aspx");
    }
    public string GetActive()
    {
        return System.IO.Path.GetFileNameWithoutExtension(System.Web.HttpContext.Current.Request.Url.AbsolutePath).ToLower();
    }
}
