using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;

/// <summary>
/// Summary description for DAO
/// </summary>
public static class DAO
    {
       // public static string connectionStr = "Data Source=.; Integrated Security=true; Initial Catalog=GoldenFriedChicken;";
        public static string connectionStr = ConfigurationManager.AppSettings.Get("myConnection").ToString();
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionStr);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            return con;
        }
        public static DataTable GetTable(string sql, SqlParameter[] param, CommandType cmdType)
        {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = cmdType;

                if (param != null)
                {
                    cmd.Parameters.AddRange(param);
                }
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;

            }
        }
        public static int IUD(string sql, SqlParameter[] param, CommandType cmdType)
        {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = cmdType;

                if (param != null)
                {
                    cmd.Parameters.AddRange(param);
                }
                return cmd.ExecuteNonQuery();

            }
        }
    }
    
