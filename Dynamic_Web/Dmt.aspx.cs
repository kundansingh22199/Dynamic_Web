using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dynamic_Web.App_Code;

namespace Dynamic_Web
{
    public partial class Dmt : System.Web.UI.Page
    {
        ClsDmt clsdmt = new ClsDmt();
        string baseurl = "https://localhost:44310";
        //string baseurl = "http://admin.zappay.in";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DmtSession();
            }
        }

        public void DmtSession()
        {
            try
            {
                DataTable dt = clsdmt.GetDmtData();
                if (dt.Rows.Count > 0)
                {
                    string imgUrlsection2img = baseurl + dt.Rows[0]["Image1"].ToString();
                    DmtImage1.ImageUrl = imgUrlsection2img.Replace("~", "");
                    DmtHeading.InnerText = dt.Rows[0]["Heading1"].ToString();
                    DmtContent1.InnerText = dt.Rows[0]["Content1"].ToString();
                    DmtContent2.InnerText = dt.Rows[0]["Content2"].ToString();
                    DmtContent3.InnerText = dt.Rows[0]["Content3"].ToString();
                    DmtContent4.InnerText = dt.Rows[0]["Content4"].ToString();

                }
                else
                {
                    DmtImage1.ImageUrl = "img/AEPS/home-slide-2.jpg";
                    DmtHeading.InnerText = "Domestic Money Transfer Service :-";
                    DmtContent1.InnerText = "Domestic money remittance as easy as mobile recharge.";
                    DmtContent2.InnerText = "And you need to collect the customers mobile number,";
                    DmtContent3.InnerText = "Beneficiary bank account number, Bank name, IFSC code and the amount to be transferred to the customer, family and Friends,.";
                    DmtContent4.InnerText = "A large number of people in India, particularly the migrant population, doesn’t have access to formal banking channels for want of proof of identity/address etc. This lead to innumerable hardships faced by them while attempting to remit money back to their family members. This is happening even when various channels for Domestic Money Transfers (DMT) are available viz. IMPS, UPI, NEFT, RTGS etc.";
                    
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}