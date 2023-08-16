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
    public partial class TermsCondition : System.Web.UI.Page
    {
        ClsTermCondition clsterm = new ClsTermCondition();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TermsSession();
            }
        }

        public void TermsSession()
        {
            try
            {
                DataTable dt = clsterm.GetTermCondition();
                if (dt != null && dt.Rows.Count > 0)
                {
                    lblHeading.InnerText = dt.Rows[0]["Section1Heading"].ToString();
                    lblContent1.InnerText = dt.Rows[0]["Section1content1"].ToString();
                    lblContent2.InnerText = dt.Rows[0]["Section1content2"].ToString();
                    lblContent3.InnerText = dt.Rows[0]["Section1content3"].ToString();
                    lblContent4.InnerText = dt.Rows[0]["Section1content4"].ToString();
                    lblContent5.InnerText = dt.Rows[0]["Section1content5"].ToString();
                    lblContent6.InnerText = dt.Rows[0]["Section1content6"].ToString();
                    lblContent7.InnerText = dt.Rows[0]["Section1content7"].ToString();
                    lblContent8.InnerText = dt.Rows[0]["Section1content8"].ToString();
                }
                else
                {
                    lblHeading.InnerText = "Online PAY SERVICES USAGE";
                    lblContent1.InnerText = "All the details should be filled by client,";
                    lblContent2.InnerText = "Details should be correct.";
                    lblContent3.InnerText = "If client has any special request in project then it should be mention in project sheet.";
                    lblContent4.InnerText = " Any other work or api integration or feature integration which is not mentioned in project sheet or service agreement will not be considered.";
                    lblContent5.InnerText = "Client has to provide his consent on agreement and project sheet before starting the work.";
                    lblContent6.InnerText = "Any new feature or service integration or api integration which is not mentioned in project sheet would be chargeable extra.";
                    lblContent7.InnerText = "We request our client to coordinate in dedicated support group for any client of technical issues where our technical team is available from 9.30 am to 6.30 pm on all working days.";
                    lblContent8.InnerText = "All the issues which is provided in technical support group will be resolve by our team within 24 working hours and this resolution time will be increase in case of any major issue.";
                    
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}