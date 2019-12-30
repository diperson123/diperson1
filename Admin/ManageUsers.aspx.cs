using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ManageUsers : System.Web.UI.Page
{
    BLLUser user = new BLLUser();
    protected void Page_Load(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
        LoadUser();
     
    }

    private void LoadUser()
    {
        DataTable dt = user.GetAllUser();
        if (dt.Rows.Count != 0)
        {
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }

    protected void showForm_click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
        btnRegister.Text = "New Users";

    }

    protected void AddNewUsers(object sender, EventArgs e)
    {
        try
        {
            if (btnRegister.Text == "New Users")             
            {
                int i = user.CreateUser(txtUsername.Text, txtPhone.Text, txtEmail.Text, txtPassword.Text, txtUserType.Text);
                if (i > 0)
                {

                    lblMsg.Text = "Successfully user created";
                    lblMsg.ForeColor = Color.Green;
                    clearFields();
                    MultiView1.ActiveViewIndex = 1;
                }
                else
                {
                    lblMsg.ForeColor = Color.Red;
                    lblMsg.Text = "Failed to register";
                }
            }
            else 
            {
                int i = user.UpdateUser(txtUsername.Text, txtPhone.Text, txtEmail.Text, txtPassword.Text, txtUserType.Text, Convert.ToInt32(HiddenField1.Value));
                if (i > 0)
                {
                    lblMsg.Text = "Updated Successfully.";
                    lblMsg.ForeColor = Color.Green;
                    clearFields();
                    MultiView1.ActiveViewIndex = 1;

                }
                else
                {
                    lblMsg.ForeColor = Color.Red;
                    lblMsg.Text = "Failed to register";
                }
            }

        }
        catch (Exception)
        {
            
            throw;
        }
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        btnRegister.Text = "Update";
        lblMsg.Text = "";

        MultiView1.ActiveViewIndex = 1;
        try
        {

            int userId = Convert.ToInt32(GridView1.SelectedDataKey.Value.ToString());
            HiddenField1.Value = userId.ToString();
            DataTable dt = user.GetUserbyUserid(userId);
            if (dt.Rows.Count != 0)
            {
                txtUsername.Text = dt.Rows[0]["Username"].ToString();
                txtPhone.Text = dt.Rows[0]["Phone"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtPassword.Text = dt.Rows[0]["Password"].ToString();
                txtConfirmPassword.Text = dt.Rows[0]["Password"].ToString();
                txtUserType.Text = dt.Rows[0]["UserType"].ToString();
            }
            MultiView1.ActiveViewIndex = 1;           
        }
        catch (Exception ex)
        {

            throw (ex);
        }

    }

    protected void deleteUsers(object sender, EventArgs e)
    {
        try
        {
            int i = user.DeleteUser(Convert.ToInt32(HiddenField1.Value));
            if (i > 0)
            {
                MultiView1.ActiveViewIndex = 0;
                LoadUser();
            }
            else { }
        }
        catch (Exception)
        {
            
            throw;
        }
    }

    protected void cancelForm(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
        clearFields();

    }

    private void clearFields()
    {
        txtUsername.Text = string.Empty;
        txtPhone.Text = string.Empty;
        txtEmail.Text = string.Empty;
        txtPassword.Text = string.Empty;
        txtConfirmPassword.Text = string.Empty;
        txtUserType.Text = string.Empty;
    }
}