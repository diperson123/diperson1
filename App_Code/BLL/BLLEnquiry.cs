using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLEnquiry
/// </summary>
public class BLLEnquiry
{
    public int CreateEnquiry(string Username, string Email, string Message)
    {
        SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Username",Username),
                new SqlParameter("@Email",Email),
                     new SqlParameter("@Message",Message)
           
            };

        return DAO.IUD("Insert into tblEnquiry values(@Username,@Email,@Message)", param, CommandType.Text);
    }

    public DataTable GetAllEnquiry()
    {
        return DAO.GetTable("Select * from tblEnquiry", null, CommandType.Text);
    }
    public int DeleteMsg(int enquiryid)
    {
        SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@enquiryid", enquiryid)
            };
        return DAO.IUD("delete from tblEnquiry where Id = @enquiryid", param, CommandType.Text);
    }

  
}