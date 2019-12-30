using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_MenuCategory : System.Web.UI.Page
{
    BLLMenuCategory cat = new BLLMenuCategory();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadGrid();
        }

    }

    private void LoadGrid()
    {
        DataTable dt = cat.GetAllCategory();
        if (dt.Rows.Count != 0)
        {
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
    protected void txtNew_Click(object sender, EventArgs e)
    {
        try
        {
            MultiView1.ActiveViewIndex = 1;
            btnSubmit.Text = "Save";

        }
        catch (Exception ex)
        {
            
            throw(ex);
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
        txtCategoryName.Text = string.Empty;
        lblHeading.Text = "Add Category";

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {        

           
                if (txtCategoryName.Text != string.Empty)
                {
                    if (btnSubmit.Text != "Update")
                    {
                        int i = cat.CreateCategory(txtCategoryName.Text);
                        if (i > 0)
                        {
                            MultiView1.ActiveViewIndex = 0;
                            LoadGrid();
                            txtCategoryName.Text = "";
                        }
                    }
                    else 
                    {
                        int i = cat.UpdateCategory(txtCategoryName.Text, Convert.ToInt32(HiddenField1.Value));
                        if (i > 0)
                        {
                            MultiView1.ActiveViewIndex = 0;
                            LoadGrid();
                            txtCategoryName.Text = "";
                        }
                    
                    }
                }
                else
                {
                    ltlMsg.Text = "Category Name Required";
                }
           
        }
        catch (Exception)
        {
            
            throw;
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int userId = Convert.ToInt32(GridView1.SelectedDataKey.Value.ToString());
        HiddenField1.Value = userId.ToString();
        DataTable dt = cat.GetCategoryCategoryId(userId);
        if (dt.Rows.Count != 0)
        {
            txtCategoryName.Text = dt.Rows[0]["MenuCategory"].ToString();
        }
        MultiView1.ActiveViewIndex = 1;
        lblHeading.Text = "Update Category";
        btnSubmit.Text = "Update";

    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            int i = cat.DeleteCategory(Convert.ToInt32(HiddenField1.Value));
            if (i > 0) 
            {
                LoadGrid();
                MultiView1.ActiveViewIndex = 0;
                lblCategoryName.Text = "";
            }

        }
        catch (Exception ex)
        {

            throw (ex);
        }
    }
}