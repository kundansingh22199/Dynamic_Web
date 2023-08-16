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
    public partial class Aeps : System.Web.UI.Page
    {
        ClsAeps clsaeps = new ClsAeps();
        string baseurl = "https://localhost:44310";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AepsSession();
            }
        }

        public void AepsSession()
        {
            try
            {
                DataTable dt = clsaeps.GetAepsData();
                if (dt.Rows.Count > 0)
                {
                    string imgUrlsection1img = baseurl + dt.Rows[0]["image1"].ToString();
                    AepsSection1Image.ImageUrl = imgUrlsection1img.Replace("~", "");

                    string imgUrlsection2img = baseurl + dt.Rows[0]["image2"].ToString();
                    AepsSection2Image.ImageUrl = imgUrlsection2img.Replace("~", "");
                    string imgUrlsection3img = baseurl + dt.Rows[0]["image3"].ToString();
                    AepsSection3Image.ImageUrl = imgUrlsection3img.Replace("~", "");

                    AepsSection1heading.InnerText = dt.Rows[0]["heading1"].ToString();
                    AepsSection2heading.InnerText = dt.Rows[0]["heading2"].ToString();
                    AepsSection3heading.InnerText = dt.Rows[0]["heading3"].ToString();
                    AepsSection1Content1.InnerText = dt.Rows[0]["content1"].ToString();
                    AepsSection2Content1.InnerText = dt.Rows[0]["content2"].ToString();
                    AepsSection3Content1.InnerText = dt.Rows[0]["content3"].ToString();
                    AepsSection1paragraph1.InnerText = dt.Rows[0]["paragraph1"].ToString();
                    AepsSection1paragraph2.InnerText = dt.Rows[0]["paragraph1"].ToString();
                    AepsSection1paragraph3.InnerText = dt.Rows[0]["paragraph1"].ToString();

                }
                else
                {
                    AepsSection1Image.ImageUrl = "img/AEPS/about.jpg";
                    AepsSection2Image.ImageUrl = "img/AEPS/about.jpg";
                    AepsSection3Image.ImageUrl = "img/AEPS/about.jpg";
                    AepsSection1heading.InnerText = "AEPS - Aadhar and Biomatric Base Payment Service";
                    AepsSection2heading.InnerText = "Aadhar Money Withdrawal";
                    AepsSection3heading.InnerText = "Aadhaar Banking";
                    AepsSection1Content1.InnerText = "Aadhaar enabled payment system (AEPS) is a secured payment method provided by the National payments corporation of India (NPCI) that allows aadhaar linked bank account holders to avail basic banking services such as balance inquiry & cash withdrawal. Customers simply need to tell our Retailer or Dis";
                    AepsSection2Content1.InnerText = "Your shop can essentially be a mini-ATM for your community too as people who need to withdraw cash can simply come to you with their Aadhar cards that are linked to bank accounts and then withdraw their money after account verification. This Aadhar money withdrawal allows a large number of people to";
                    AepsSection3Content1.InnerText = "You can also offer other fintech services using the same AePS mechanism by being a free AePS service provider. Your AePS online services can essentially include AePS payment, AePS withdrawal, and AePS money transfer, all with just the use of Aadhar biometric verification for Aadhar Baking. You will";
                    AepsSection1paragraph1.InnerText = "Cash withdrawal";
                    AepsSection1paragraph2.InnerText = "Cash withdrawal";
                    AepsSection1paragraph3.InnerText = "Cash withdrawal";
                }
            }
            catch (Exception)
            {

            }
        }
    }
}