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
    public partial class FasTag : System.Web.UI.Page
    {
        ClsFastTagMaster clsFastTag = new ClsFastTagMaster();

        string baseurl = "https://localhost:44310";
        //string baseurl = "http://admin.zappay.in";
        protected void Page_Load(object sender, EventArgs e)
        {
            FtagSectionGet();
        }

        public void FtagSectionGet()
        {
            try
            {
                DataTable dt = clsFastTag.GetFasTagData();
                if (dt.Rows.Count > 0)
                {
                    string FtagSectioimg1 = baseurl + dt.Rows[0]["image1"].ToString();
                    FtagSection1image.ImageUrl = FtagSectioimg1.Replace("~", "");
                    string FtagSectioimg2 = baseurl + dt.Rows[0]["image2"].ToString();
                    FtagSection2image.ImageUrl = FtagSectioimg2.Replace("~", "");
                    string FtagSectioimg3 = baseurl + dt.Rows[0]["image3"].ToString();
                    FtagSection3Image.ImageUrl = FtagSectioimg3.Replace("~", "");
                    ftagSectionheading.InnerText = dt.Rows[0]["heading1"].ToString();
                    FtagSection3Heading.InnerText = dt.Rows[0]["heading2"].ToString();
                    FtagSection2heading.InnerText = dt.Rows[0]["heading3"].ToString();
                    FtagSection1btnlink.HRef = dt.Rows[0]["Buttonlink"].ToString();
                    FtagSection1content.InnerText = dt.Rows[0]["content1"].ToString();
                    FtagSection2content.InnerText = dt.Rows[0]["content2"].ToString();
                    FtagSection3content.InnerText = dt.Rows[0]["content3"].ToString();
                }
                else
                {
                    FtagSection1image.ImageUrl = "assets/images/fastag_img.png";
                    FtagSection2image.ImageUrl = "assets/images/fastag1.png";
                    FtagSection3Image.ImageUrl = "assets/images/fastag2.png";
                    ftagSectionheading.InnerText = "FASTag";
                    FtagSection3Heading.InnerText = "WHAT IS FASTag?";
                    FtagSection2heading.InnerText = "HOW FASTag WORKS?";
                    FtagSection1btnlink.HRef = "";
                    FtagSection1content.InnerText = "FASTag is a device that employs Radio Frequency Identification (RFID) technology for making toll payments directly from the Prepaid Account linked to it. It is affixed on the windscreen of your vehicle and enables you to drive through toll plazas, without stopping for cash transactions.";
                    FtagSection2content.InnerText = "FASTag is affixed to the windscreen of the vehicle and is linked to a prepaid account. Toll payments are made through RFID, as the vehicle drives through the toll gate, which means you do not have to stop at a toll plaza on your journey.";
                    FtagSection3content.InnerText = "FASTag is affixed to the windscreen of the vehicle and is linked to a prepaid account. Toll payments are made through RFID, as the vehicle drives through the toll gate, which means you do not have to stop at a toll plaza on your journey.";
                }


            }
            catch (Exception ex)
            {

            }
        }
    }
}