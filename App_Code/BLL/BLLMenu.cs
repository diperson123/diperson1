using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLMenu
/// </summary>
public class BLLMenu
{
    public DataTable GetAllMenu()
    {
        return DAO.GetTable("Select A.*, B.* from tblMenu A inner join tblMenuCategory B on B.Id = A.CategoryId", null, CommandType.Text);
    }
    public DataTable GetAllMenuForChicken()
    {
        return DAO.GetTable("  Select A.*, B.* from tblMenu A inner join tblMenuCategory B on B.Id = A.CategoryId where CategoryId = 3", null, CommandType.Text);
    }

    public DataTable GetMenuByCategoryId(int id)
    {
        SqlParameter[] param = new SqlParameter[]
           {
           new SqlParameter("@a",id)
           };
        return DAO.GetTable("Select A.*, B.* from tblMenu A inner join tblMenuCategory B on B.Id = A.CategoryId where A.CategoryId = @a", param, CommandType.Text);
    }

    public DataTable GetMenuByMenuId(int id)
    {
        SqlParameter[] param = new SqlParameter[]
           {
           new SqlParameter("@a",id)
           };
        return DAO.GetTable("Select A.*, B.* from tblMenu A inner join tblMenuCategory B on B.Id = A.CategoryId where A.Id = @a", param, CommandType.Text);
    }

    public int CreateMenu(string foodname, int categoryId, decimal price, string image, string description)
    {
        SqlParameter[] param = new SqlParameter[]
           {
           new SqlParameter("@a",foodname),
           new SqlParameter("@b",price),
           new SqlParameter("@c",categoryId),
           new SqlParameter("@d",image),
           new SqlParameter("@e",description),
           };
        return DAO.IUD("Insert into tblMenu values(@a,@b,@c,@d,@e)", param, CommandType.Text);
    }

    public int UpdateMenu(string foodname, int categoryId, decimal price, string image, string description, int id)
    {
        SqlParameter[] param = new SqlParameter[]
           {
           new SqlParameter("@a",foodname),
           new SqlParameter("@b",categoryId),
           new SqlParameter("@c",price),
           new SqlParameter("@d",image),
           new SqlParameter("@e",description),
           new SqlParameter("@e",id)
           };
        return DAO.IUD("Update tblMenu set Foodname=@a, CategoryId=@b,Price=@c, Image=@d, description=@e where Id=@e", param, CommandType.Text);
    }

    public int DeleteMenu(int id)
    {
        SqlParameter[] param = new SqlParameter[]
           {           
           new SqlParameter("@d",id)
           };
        return DAO.IUD("delete from tblMenu where Id=@d", param, CommandType.Text);
    }

    public DataTable CheckImageInDatabase(string imageName)
    {
        SqlParameter[] param = new SqlParameter[]
           {           
           new SqlParameter("@d",imageName)
           };
        return DAO.GetTable("Select * from tblMenu where Image = @d", param, CommandType.Text);
    }

    public DataTable GetFileName(int id)
    {
        SqlParameter[] param = new SqlParameter[]
           {           
           new SqlParameter("@d",id)
           };
        return DAO.GetTable("Select * from tblMenu where Id = @d", param, CommandType.Text);
    }

    public DataTable SearchMenuByFoodname(string foodname)
    { 
       SqlParameter[] param = new SqlParameter[]
           {           
           new SqlParameter("@d",foodname + "%")
           };
        return DAO.GetTable("Select * from tblMenu where Foodname like @d", param, CommandType.Text);
    }
    
}