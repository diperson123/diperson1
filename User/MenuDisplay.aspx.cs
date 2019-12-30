using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_MenuDisplay : System.Web.UI.Page
{
    BLLMenu men = new BLLMenu();
    BLLCart cart = new BLLCart();
    int id;
    int userId;
    int price;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Convert.ToInt32(Request.QueryString["id"]);
        DataTable menuDetail = men.GetMenuByMenuId(id);
        FormViewMenu.DataSource = menuDetail;
        FormViewMenu.DataBind();
    }
    protected void addToCart_Click(object sender, EventArgs e)
    {
        if (Session["UserId"] != null)
        {
            int userId = Convert.ToInt32(Session["UserId"].ToString());
            DataTable menuDetail = men.GetMenuByMenuId(id);
            price = Convert.ToInt32(menuDetail.Rows[0]["price"].ToString());
            DataTable dt = cart.SearchItemByMenuIdAndUserId(id, userId);
            if (dt.Rows.Count != 0)
            {
                int cartId = Convert.ToInt32(dt.Rows[0]["Id"].ToString());
                int OldQuantity = Convert.ToInt32(dt.Rows[0]["Quantity"].ToString());
                int quantity = Convert.ToInt32(menuQuantity.Text.ToString());
                int newQuantity = OldQuantity + quantity;
                int i = cart.UpdateCartByCartId(cartId, newQuantity);
                if (i > 0)
                {
                    Response.Redirect("Menu.aspx");
                }

            }
            else
            {
                int quantity = Convert.ToInt32(menuQuantity.Text.ToString());
                int i = cart.CreateCart(userId, id, quantity, (price * quantity), false);
                if (i > 0)
                {
                    Response.Redirect("Menu.aspx");
                }
            }
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }
}