using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Cart
/// </summary>
public class BLLCart
{
    public int CreateCart(int userId, int menuId, int quantity, decimal total, bool isPurchased)
    {
        SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a", userId),
                new SqlParameter("@b", menuId),
                new SqlParameter("@c", quantity),
                new SqlParameter("@d", isPurchased),
                new SqlParameter("@e", total),

            };
        return DAO.IUD("Insert into tblCart values (@a,@b,@c,@d,@e)", param, CommandType.Text);
    }

    public int RemoveItem(int cartId)
    {
        SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a", cartId),             

            };
        return DAO.IUD("Delete from tblCart where Id=@a", param, CommandType.Text);
    }


    public DataTable GetAllCartItems(int userId)
    {
        SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a", userId)
            };
        return DAO.GetTable("Select A.*, B.* from tblCart A inner join tblMenu B on B.Id = A.MenuId where A.UserId = @a", param, CommandType.Text);

    }

    public int PurchaseAllItems(int menuId, int price, int quantity, decimal total, DateTime date, int UserId, bool isPaid)
    {
        SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a", menuId),
                new SqlParameter("@b", price),
                new SqlParameter("@c", quantity),
                new SqlParameter("@d", total),
                new SqlParameter("@e", date),
                new SqlParameter("@f",UserId),
                new SqlParameter("@g", isPaid),

            };
        return DAO.IUD("Insert into tblOrder values (@a,@b,@c,@d,@e,@f,@g)", param, CommandType.Text);
    }


    public int DeleteCartItemByUserId(int userId)
    {
        SqlParameter[] param = new SqlParameter[]
            {
                
                new SqlParameter("@f", userId),

            };
        return DAO.IUD("Delete from tblCart where UserId = @f", param, CommandType.Text);
    }

    public DataTable SearchItemByMenuIdAndUserId(int menunId, int userId)
    {
        SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a", menunId),
                new SqlParameter("@b", userId),

            };
        return DAO.GetTable("Select * from tblCart where MenuId = @a and UserId = @b", param, CommandType.Text);
    }

    public int UpdateCartByCartId(int cartId, int quantity)
    {
        SqlParameter[] param = new SqlParameter[]
            {
                
                new SqlParameter("@f", cartId),
                new SqlParameter("@g", quantity),

            };
        return DAO.IUD("Update tblCart set Quantity = @g where Id = @f", param, CommandType.Text);
    }


}