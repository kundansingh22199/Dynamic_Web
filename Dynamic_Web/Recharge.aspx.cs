using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dynamic_Web.App_Code;
using System.Data;

namespace Dynamic_Web
{
    public partial class Recharge : System.Web.UI.Page
    {
        ClsRecharge clsrecharge = new ClsRecharge();
        string baseurl = "https://localhost:44310";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RechargeSession();
            }
        }

        public void RechargeSession()
        {
            try
            {
                DataTable dt = clsrecharge.GetRechargeData();
                if (dt.Rows.Count > 0)
                {
                    string imgUrlsection2img = baseurl + dt.Rows[0]["image1"].ToString();
                    RechargeImage.ImageUrl = imgUrlsection2img.Replace("~", "");
                    RechargeSectionHeading.InnerText = dt.Rows[0]["heading1"].ToString();
                    PreReSectionContent1.InnerText = dt.Rows[0]["content1"].ToString();
                    PreReSectionContent2.InnerText = dt.Rows[0]["content2"].ToString();
                    PreReSectionContent3.InnerText = dt.Rows[0]["content3"].ToString();
                }
                else
                {
                    RechargeImage.ImageUrl = "img/AEPS/3014BankitRechargeImage.png";
                    RechargeSectionHeading.InnerText = "PREPAID RECHARGE";
                    PreReSectionContent1.InnerText = "You can now get the Prepaid, Postpaid and DTH services recharged for yours customers or Family and earn attractive commission on every transaction.";
                    PreReSectionContent2.InnerText = "With a vision to empower retailers all over India, including cities and rural areas, we provide retailer app services that are easy-to-use and offer best-in-class.";
                    PreReSectionContent3.InnerText = "services to your customers, As you provide multi-mobile recharge companies and services quickly at your hand. Not only add essential services to your business but also earn commissions on each recharge, bill payment or other services provided.";
                    
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}