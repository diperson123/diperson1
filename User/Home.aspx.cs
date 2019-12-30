using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_Home : System.Web.UI.Page
{
    BLLMenu menu = new BLLMenu();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = menu.GetAllMenuForChicken();
        RptrMenu.DataSource = dt;
        RptrMenu.DataBind();
    }
}