using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

public class BLLPromotion
{
    public int CreatePromotion(int menuId, decimal discount, DateTime fromDate, DateTime toDate)
    {
        SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a",menuId),
                new SqlParameter("@b",discount),
                new SqlParameter("@c",fromDate),
                new SqlParameter("@d",toDate),
            };

        return DAO.IUD("Insert into tblPromotion values(@a,@b,@c,@d)", param, CommandType.Text);
    }

    public int UpdatePromotion(int menuId, decimal discount, DateTime fromDate, DateTime toDate, int id)
    {
        SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a",menuId),
                new SqlParameter("@b",discount),
                new SqlParameter("@c",fromDate),
                new SqlParameter("@d",toDate),
                new SqlParameter("@e",id),
            };

        return DAO.IUD("Update tblPromotion set MenuId=@a, Discount=@b, FromDate=@c, ToDate=@d where Id=@e", param, CommandType.Text);
    }

    public int DeletePromotion(int id)
    {
        SqlParameter[] param = new SqlParameter[]
            {               
                new SqlParameter("@e",id)
            };

        return DAO.IUD("delete from tblPromotion where Id=@e", param, CommandType.Text);
    }

    public int GetPromotionById(int id)
    {
        SqlParameter[] param = new SqlParameter[]
            {               
                new SqlParameter("@e",id)
            };

        return DAO.IUD("select * from tblPromotion where Id=@e", param, CommandType.Text);
    }


    public DataTable GetAllPromotion()
    {
        return DAO.GetTable("Select A.*, B.* from tblPromotion A inner join tblMenu B on B.Id = A.MenuId", null, CommandType.Text);
    }
}