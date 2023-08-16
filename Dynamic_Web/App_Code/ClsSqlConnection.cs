using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dynamic_Web.App_Code
{
    public class ClsSqlConnection
    {
        public string OurConn = "Data Source=103.48.51.217,1232;Initial Catalog=KundanWeb_db;User ID=sa;Password=ffbj*2hFWn#2sn3@dd";
        public string GetConnectionString()
        {
            return OurConn;
        }
    }
}