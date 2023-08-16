﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Dynamic_Web.App_Code;
using System.Data.SqlClient;

namespace Dynamic_Web.App_Code
{
    public class ClsWhyUsMaster: ClsSqlConnection
    {
        public DataTable GetWhyUs()
        {
            try
            {
                SqlConnection con = new SqlConnection(OurConn);
                SqlDataAdapter adp = new SqlDataAdapter("SP_GetWhyUs", con);
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