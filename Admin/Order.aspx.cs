using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Order : System.Web.UI.Page
{
    BLLOrder order = new BLLOrder();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = order.GetAllOrder();
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}