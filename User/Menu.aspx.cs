using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_Menu : System.Web.UI.Page
{
    BLLMenuCategory category = new BLLMenuCategory();
    BLLMenu men = new BLLMenu();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = category.GetAllCategory();
        rptrCategory.DataSource = dt;
        rptrCategory.DataBind();
    }    

    protected void menuCategoryId_Click(object sender, EventArgs e)
    {
        int categoryId = Convert.ToInt32((sender as Button).CommandArgument);
        var menus = men.GetMenuByCategoryId(categoryId);
        RptrMenu.DataSource = menus;
        RptrMenu.DataBind();
    }
}