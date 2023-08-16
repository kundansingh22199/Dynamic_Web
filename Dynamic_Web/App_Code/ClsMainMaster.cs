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
    public class ClsMainMaster:ClsSqlConnection
    {
        public DataTable GetMainMasterData()
        {
            try
            {
                SqlConnection con = new SqlConnection(OurConn);
                SqlDataAdapter adp = new SqlDataAdapter("SP_GetMainMaster", con);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable GetServiceData()
        {
            SqlConnection con = new SqlConnection(OurConn);
            SqlCommand cmd = new SqlCommand("SP_GetServiceData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetProductData()
        {
            try
            {
                SqlConnection con = new SqlConnection(OurConn);
                SqlDataAdapter adp = new SqlDataAdapter("SP_GetProductData", con);
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
    }
}