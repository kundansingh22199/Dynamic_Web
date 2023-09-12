using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dynamic_Web.App_Code;

namespace Dynamic_Web
{
    public partial class Contact : System.Web.UI.Page
    {
        ClsContact clscont = new ClsContact();
        ClsMainMaster clsMain = new ClsMainMaster();
        string baseurl = "https://localhost:44310";
        //string baseurl = "http://admin.zappay.in";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ContactSession();
            }
        }

        public void ContactSession()
        {
            //DataTable dt = clscont.GetContactData();
            DataTable dt1 = clsMain.GetMainMasterData();
            DataTable dt = clscont.GetContactData();
            if ((dt != null && dt.Rows.Count > 0) && (dt1 != null && dt1.Rows.Count > 0))
            {
                string imagesection1 = baseurl + dt.Rows[0]["Section1image"].ToString();
                //string imagesection2 = baseurl + dt.Rows[0]["Section2image"].ToString();
                section1image.ImageUrl = imagesection1.Replace("~", "");
                contectno.InnerText = dt1.Rows[0]["Contactno"].ToString();
                emailid.InnerText = dt1.Rows[0]["conatactemail"].ToString();
                addressno.InnerText = dt1.Rows[0]["CompanyAddress"].ToString();
                section1heading.InnerText = dt.Rows[0]["Section1heading"].ToString();
                section1content.InnerText = dt.Rows[0]["Section1content"].ToString();
            }
            else
            {

                section1image.ImageUrl = "img/AEPS/about.jpg"; 
                contectno.InnerText = "+91 9798501225";
                emailid.InnerText = " Youremail.com";
                addressno.InnerText = " Sector-16, Noida";
                section1heading.InnerText = "Contact Us";
                section1content.InnerText = "You will find yourself working in a true partnership that results in an incredible experience, and an end product that is the best.With dedicated engineers on-hand 24/7, we’re set up to become an extension of your team..";
            }
        }

        protected void btnSendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                int result = clscont.SendSmsContact(exampleFormControlInput1.Value, exampleFormControlInput2.Value, exampleFormControlTextarea1.Value);
                if (result == 1)
                {
                    MessageShow.Text = "Message Has been send success";
                    MessageShow.ForeColor = Color.Green;
                    exampleFormControlInput1.Value = "";
                    exampleFormControlInput2.Value = "";
                    exampleFormControlTextarea1.Value = "";
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}