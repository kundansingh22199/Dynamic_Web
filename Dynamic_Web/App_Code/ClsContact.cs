using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Dynamic_Web.App_Code;
using System.Data;
using System.Data.SqlClient;

namespace Dynamic_Web.App_Code
{
    public class ClsContact:ClsSqlConnection
    {
        public DataTable GetContactData()
        {
            try
            {
                SqlConnection con = new SqlConnection(OurConn);
                SqlDataAdapter adp = new SqlDataAdapter("SP_GetContact", con);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public int SendSmsContact(string name, string email, string message)
        {
            try
            {
                string constr = GetConnectionString();
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("sp_tblContactmassage", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@Message", message);
                con.Open();
                int result = cmd.ExecuteNonQuery();
                con.Close();
                return result;

            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}