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
    public class ClsAeps:ClsSqlConnection
    {
        public DataTable GetAepsData()
        {
            try
            {
                SqlConnection con = new SqlConnection(OurConn);
                SqlDataAdapter adp = new SqlDataAdapter("SP_GetAPES", con);
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