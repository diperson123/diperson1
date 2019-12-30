using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLMenuCategory
/// </summary>
public class BLLMenuCategory
{
    public DataTable GetAllCategory()
    {
        return DAO.GetTable("Select * from tblMenuCategory", null, CommandType.Text);
    }

    public DataTable GetCategoryCategoryId(int categoryId)
    {
        SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a", categoryId)
            };
        return DAO.GetTable("Select * from tblMenuCategory where Id=@a", param, CommandType.Text);
    }

    public int CreateCategory(string categoryName)
    {
        SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@categoryName", categoryName)
            };
        return DAO.IUD("Insert into tblMenuCategory values (@categoryName)", param, CommandType.Text);
    }

    public int UpdateCategory(string categoryName, int categoryId)
    {
        SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@categoryName", categoryName), 
                new SqlParameter("@categoryId", categoryId)
            };
        return DAO.IUD("Update tblMenuCategory set MenuCategory= @categoryName where Id = @categoryId", param, CommandType.Text);
    }

    public int DeleteCategory(int categoryId)
    {
        SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@categoryId", categoryId)
            };
        return DAO.IUD("delete from tblMenuCategory where Id = @categoryId", param, CommandType.Text);
    }

    public DataTable SearchCategory(string categoryName)
    {
        SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@searchName", categoryName + "%"), 
            };
        return DAO.GetTable("Select * from tblMenuCategory where MenuCategory like @searchName ", null, CommandType.Text);
    }

}