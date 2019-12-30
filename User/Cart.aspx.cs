using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_Cart : System.Web.UI.Page
{
    BLLCart cart = new BLLCart();
    int userId;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["UserId"] != null)
            {
                LoadGrid();
            }
            else
            {
                Response.Redirect("Login.aspx");

            }

        }
    }

    private void LoadGrid()
    {
        userId = Convert.ToInt32(Session["UserId"].ToString());
        DataTable dt = cart.GetAllCartItems(userId);
        if (dt.Rows.Count != 0)
        {
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }

    protected void removeItem(object sender, EventArgs e)
    {
        int cartId = Convert.ToInt32((sender as Button).CommandArgument);
        int i = cart.RemoveItem(cartId);
        if (i > 0)
        {
            Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('Item removed Successfully.')", true);
            Response.Redirect("Home.aspx");
        }
        else
        {
            Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('Failed To remove Item.')", true);

        }
    }

    protected void PurchaseAllItem_Click(object sender, EventArgs e)
    {
        int user = Convert.ToInt32(Session["UserId"].ToString());

        foreach (GridViewRow row in GridView1.Rows)
        {
            int menuId = Convert.ToInt32(row.Cells[0].Text);
            int price = Convert.ToInt32(row.Cells[3].Text);
            int quantity = Convert.ToInt32(row.Cells[4].Text);
            decimal total = Convert.ToDecimal(row.Cells[5].Text);
            DateTime date = DateTime.Now;
           int i = cart.PurchaseAllItems(menuId, price, quantity, total, date, user,false);
        }

        int j = cart.DeleteCartItemByUserId(user);
        Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('Item Successfully Purchased.')", true);
        Response.Redirect("Home.aspx");

        if (j > 0)
        {
            LoadGrid();
        }

    }
}