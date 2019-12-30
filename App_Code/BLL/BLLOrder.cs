using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLOrder
/// </summary>
public class BLLOrder
{
    public int CreateOrder(int userId, int menuId, DateTime orderDateTime, int quantity, decimal total,
            int paymentType, int orderType)
    {
        SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@userId", userId), 
                new SqlParameter("@menuId", menuId), 
                new SqlParameter("@orderDateTime", orderDateTime), 
                new SqlParameter("@quantity", quantity), 
                new SqlParameter("@total", total), 
                new SqlParameter("@paymentType", paymentType), 
                new SqlParameter("@orderType", orderType)
            };
        return DAO.IUD(
            "Insert into tblOrder values('@userId','@menuId','@orderDateTime', '@quantity', '@total', '@paymentType', '@orderType')",
            param, CommandType.Text);
    }

    public int UpdateOrder(int userId, int menuId, DateTime orderDateTime, int quantity, decimal total,
        int paymentType, int orderType, int orderId)
    {
        SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@userId", userId), 
                new SqlParameter("@menuId", menuId), 
                new SqlParameter("@orderDateTime", orderDateTime), 
                new SqlParameter("@quantity", quantity), 
                new SqlParameter("@total", total), 
                new SqlParameter("@paymentType", paymentType), 
                new SqlParameter("@orderType", orderType),
                new SqlParameter("@orderId", orderId)
            };
        return DAO.IUD("Update tblOrder  set UserId = @userId, MenuId= @menuId, OrderDateTime= @orderDateTime, Quantity= @quantity, Total = @total, PaymentType = @paymentType, OrderType =@orderType wehre Id = @orderId)",
            param, CommandType.Text);
    }

    public int DeleteOrder(int orderId)
    {
        SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@orderId", orderId)
            };
        return DAO.IUD("Delete from tblOrder wehre Id = @orderId)",
            param, CommandType.Text);
    }

    public DataTable GetAllOrder()
    {
        return DAO.GetTable("select A.DateTimeOfPurchase, A.Price, A.Total, A.Quantity, B.FoodName, C.Username  from tblOrder A inner join tblMenu B on A.MenuId = B.Id inner join tblUser C on A.UserId = C.Id", null, CommandType.Text);
    }

    public DataTable GetOrderByUserId(int userId)
    {
        SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@userId", userId), 
            };
        return DAO.GetTable("Select * from tblOrder where UserId = @userId order by OrderDateTime ASC", param, CommandType.Text);
    }
}