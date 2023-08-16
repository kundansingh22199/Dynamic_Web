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
    public partial class Bbps : System.Web.UI.Page
    {
        ClsBbps clsbbps = new ClsBbps();
        string baseurl = "https://localhost:44310";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BbpsSession();
            }
        }

        public void BbpsSession()
        {
            try
            {
                DataTable dt = clsbbps.GetBbpsData();
                if (dt.Rows.Count > 0)
                {
                    bbpsHeading.InnerText = dt.Rows[0]["Heading1"].ToString();
                    bbpsHeading1.InnerText = dt.Rows[0]["Heading1"].ToString();
                    bbpsContent.InnerText = dt.Rows[0]["content1"].ToString();
                    string bbpssectimg1 = baseurl + dt.Rows[0]["Image1"].ToString();
                    bbpsImage.ImageUrl = bbpssectimg1.Replace("~", "");
                    bbpsParagraph1.InnerText = dt.Rows[0]["Paragraph1"].ToString();
                    bbpsParagraph2.InnerText = dt.Rows[0]["Paragraph2"].ToString();
                    bbpsParagraph3.InnerText = dt.Rows[0]["Paragraph3"].ToString();
                    bbpsParagraph4.InnerText = dt.Rows[0]["Paragraph4"].ToString();

                }
                else
                {
                    bbpsHeading.InnerText = "BBPS (BHARAT BILL PAYMENT SYSTEM)";
                    bbpsContent.InnerText = "Bharat Bill Payment System is an integrated bill payment system in India offering interoperable and accessible bill payment service to customers through a network of agents of registered member as Agent,";
                    bbpsImage.ImageUrl = "img/AEPS/about.jpg";
                    bbpsParagraph1.InnerText = "Institutions, enabling multiple payment modes, and providing instant confirmation of payment,";
                    bbpsParagraph2.InnerText = "BBPS Pay enables its Retailers to accept payments for all utility bills such as water,";
                    bbpsParagraph3.InnerText = "Electricity, Gas, and Broadband through the Bharat Bill Payment System (BBPS).";
                    bbpsParagraph4.InnerText = "We are committed to provide highest margin to our Partners.";
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}