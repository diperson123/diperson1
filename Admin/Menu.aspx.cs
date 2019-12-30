using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Menu : System.Web.UI.Page
{
    BLLMenuCategory cat = new BLLMenuCategory();
    BLLMenu menu = new BLLMenu();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadCategory();
            LoadGrid();
            MultiView1.ActiveViewIndex = 0;

        }
    }

    private void LoadGrid()
    {
        DataTable dt1 = menu.GetAllMenu();
        if (dt1.Rows.Count != 0)
        {
            GridView1.DataSource = dt1;
            GridView1.DataBind();
        }
    }

    private void LoadCategory()
    {
        DataTable dt = cat.GetAllCategory();
        if (dt.Rows.Count != 0)
        {
            ddlMenuCategory.DataSource = dt;
            ddlMenuCategory.DataTextField = "MenuCategory";
            ddlMenuCategory.DataValueField = "Id";
            ddlMenuCategory.DataBind();
            ddlMenuCategory.Items.Insert(0, new ListItem("-- please select --", "0"));

        }
    }
    protected void btnNew_Click(object sender, EventArgs e)
    {
        try
        {
            ltlMsg.Text = string.Empty;
            lblHeading.Text = "Add Menu";
            btnSubmit.Text = "Save";
            ClearFields();
            LoadCategory();
            MultiView1.ActiveViewIndex = 1;
        }
        catch (Exception ex)
        {

            throw (ex);
        }


    }

    private void ClearFields()
    {
        txtFoodname.Text = string.Empty;
        txtPrice.Text = string.Empty;
        ddlMenuCategory.SelectedIndex = -1;
        lblImageName.Text = string.Empty;

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        try
        {
            ClearFields();
            ltlMsg.Text = string.Empty;
            MultiView1.ActiveViewIndex = 0;
            LoadGrid();
        }
        catch (Exception ex)
        {

            throw (ex);
        }

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
        try
        {

            int menuId = Convert.ToInt32(GridView1.SelectedDataKey.Value.ToString());
            HiddenField1.Value = menuId.ToString();
            DataTable dt = menu.GetMenuByMenuId(menuId);
            if (dt.Rows.Count != 0)
            {
                txtFoodname.Text = dt.Rows[0]["FoodName"].ToString();
                ddlMenuCategory.Text = dt.Rows[0]["CategoryId"].ToString();
                txtPrice.Text = dt.Rows[0]["Price"].ToString();
                lblImageName.Text = dt.Rows[0]["Image"].ToString();
            }
            MultiView1.ActiveViewIndex = 1;
            lblHeading.Text = "Update Menu";
            btnSubmit.Text = "Update";
        }
        catch (Exception ex)
        {

            throw (ex);
        }

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtFoodname.Text != null && txtPrice.Text != null && ddlMenuCategory.SelectedIndex != -1 && txtDescription.Text != null)
            {
                string ext = System.IO.Path.GetExtension(this.FileUploadImage.PostedFile.FileName).ToLower();
                if (!(ext.Equals(".jpg") || ext.Equals(".png") || ext.Equals(".gif") || ext.Equals(".jpeg"))){
                //if (ext != ".jpg" || ext != ".png" || ext != ".gif" || ext != ".jpeg")
                    Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('Please choose only .jpg, .png and .gif image types!')", true);
                }
                else {
                    if (btnSubmit.Text != "Update")
                    {
                        DataTable dt = menu.CheckImageInDatabase(FileUploadImage.FileName);
                        if (dt.Rows.Count != 0)
                        {
                            ltlMsg.Text = "There is another image with same name ! ";
                        }
                        else
                        {
                            int i = menu.CreateMenu(txtFoodname.Text, Convert.ToInt32(ddlMenuCategory.SelectedItem.Value), Convert.ToDecimal(txtPrice.Text), FileUploadImage.FileName, txtDescription.Text);
                            if (i > 0)
                            {
                                FileUploadImage.SaveAs(Server.MapPath("~/MenuImages/" + FileUploadImage.FileName));
                                ltlMsg.Text = "Successfully added menu.";
                                ClearFields();
                            }
                            else
                            {
                                ltlMsg.Text = "Failed to add menu.";
                                ClearFields();
                            }
                        }
                    }
                    else
                    {
                        DataTable dt = menu.CheckImageInDatabase(FileUploadImage.FileName);
                        if (dt.Rows.Count != 0)
                        {
                            ltlMsg.Text = "There is another image with same name !";
                        }
                        else
                        {
                            string fileName;
                            string oldfileName="";
                            if (FileUploadImage.HasFile)
                            {
                                DataTable dtImage = menu.GetFileName(Convert.ToInt32(HiddenField1.Value));
                                oldfileName = dtImage.Rows[0]["Image"].ToString();
                                fileName = FileUploadImage.FileName;
                            }
                            else
                            {
                                fileName = lblImageName.Text;
                            }
                            int i = menu.UpdateMenu(txtFoodname.Text, Convert.ToInt32(ddlMenuCategory.SelectedItem.Value), Convert.ToDecimal(txtPrice.Text), fileName, txtDescription.Text, Convert.ToInt32(HiddenField1.Value));
                            if (i > 0)
                            {
                                if (oldfileName != null && oldfileName != fileName)
                                {
                                    if (File.Exists(Server.MapPath("~/Images/" + oldfileName)))
                                    {
                                        File.Delete(Server.MapPath("~/Images/" + oldfileName));
                                    }
                                }
                                ltlMsg.Text = "Successfully Updated.";
                                ClearFields();
                            }
                            else
                            {
                                ltlMsg.Text = "Failed to update.";
                                ClearFields();
                            }
                        }
                    }
                
                }
                
            }
            else
            {
                ltlMsg.Text = "All fields required.";
            }

        }
        catch (Exception ex)
        {

            throw (ex);
        }
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            string oldfileName = "";
            DataTable dtImage = menu.GetFileName(Convert.ToInt32(HiddenField1.Value));
            oldfileName = dtImage.Rows[0]["Image"].ToString();
            int i = menu.DeleteMenu(Convert.ToInt32(HiddenField1.Value));
            if(i >0)
            {
                File.Delete(Server.MapPath("~/MenuImages/" + oldfileName));
                Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('Successfully deleted!')", true);
                LoadGrid();
                MultiView1.ActiveViewIndex = 0;
            }
        }
        catch (Exception ex)
        {

            throw;
        }
    }
}