using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLUser
/// </summary>
public class BLLUser
{
    public DataTable CheckUserLogin(string username, string password)
    {
        SqlParameter[] param = new SqlParameter[]
           {
           new SqlParameter("@username",username),
            new SqlParameter("@password",password)
           };
        return DAO.GetTable("select *from tblUser where username=@username and password=@password", param, CommandType.Text);

    }
    public DataTable GetUserbyUserid(int userid)
    {
        SqlParameter[] param = new SqlParameter[]
           {
           new SqlParameter("@userid",userid)
           
           };
        return DAO.GetTable("select *from tblUser where id=@userid ", param, CommandType.Text);

    }
    public DataTable GetAllUser()
    {

        return DAO.GetTable("select *from tblUser", null, CommandType.Text);

    }
    public int CreateUser(string username, string phone, string email, string password, string usertype)
    {
        SqlParameter[] param = new SqlParameter[]
          {
              
              new SqlParameter("@a",username),
              new SqlParameter("@b",phone),
              new SqlParameter("@c",email),
              new SqlParameter("@d",password),
              new SqlParameter("@e",usertype),
          };
        return DAO.IUD("insert into tblUser  values(@a,@b,@c,@d,@e)", param, CommandType.Text);
    }
    public int UpdateUser(string username, string phone, string email, string password, string usertype, int id)
    {
        SqlParameter[] param = new SqlParameter[]
          {
             
              new SqlParameter("@a",username),
              new SqlParameter("@b",phone),
              new SqlParameter("@c",email),
              new SqlParameter("@d",password),
              new SqlParameter("@e",usertype),
              new SqlParameter("@f",id)
          };
        return DAO.IUD("update tblUser set username=@a, phone=@b, email=@c,  password=@d, usertype=@e where id=@f", param, CommandType.Text);
    }
    public int DeleteUser(int userid)
    {
        SqlParameter[] param = new SqlParameter[]
          {
            
                    new SqlParameter("@e",userid)
          };
        return DAO.IUD("delete from tblUser  where id=@e", param, CommandType.Text);
    }


    public DataTable CheckEmail(string email)
    {
        SqlParameter[] param = new SqlParameter[]
          {            
                    new SqlParameter("@e",email)
          };
        return DAO.GetTable("select * from tblUser where Email=@e", param, CommandType.Text);
    }






    public int UpdateUser(string p1, string p2, string p3, string p4, int p5, int p6)
    {
        throw new NotImplementedException();
    }
}