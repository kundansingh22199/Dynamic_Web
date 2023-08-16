﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Dynamic_Web.App_Code;
using System.Data.SqlClient;

namespace Dynamic_Web.App_Code
{
    public class ClsTeamMaster:ClsHomeSession
    {

        public DataTable GetTeamMaster()
        {
            try
            {
                SqlConnection con = new SqlConnection(OurConn);
                SqlDataAdapter adp = new SqlDataAdapter("SP_GetTeamMaster", con);
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