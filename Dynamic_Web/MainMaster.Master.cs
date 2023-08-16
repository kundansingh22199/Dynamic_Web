using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Dynamic_Web.App_Code;

namespace Dynamic_Web
{
    public partial class MainMaster : System.Web.UI.MasterPage
    {
        ClsMainMaster clsmain = new ClsMainMaster();
        string baseurl = "https://localhost:44310";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MainSession();
                GetService();
                GetProduct();
            }
        }

        public void MainSession()
        {
            try
            {
                DataTable dt = clsmain.GetMainMasterData();
                if (dt != null && dt.Rows.Count > 0)
                {
                    string logoimg = dt.Rows[0]["ComapnyLogo"].ToString();
                    //logo.Src = logoimg.Replace("~", "");
                    lblcontentno.InnerText = dt.Rows[0]["ContactNo"].ToString();
                    lblcontentnoTop.InnerText = dt.Rows[0]["ContactNo"].ToString();
                    lblcontectemail.InnerText = dt.Rows[0]["ConatactEmail"].ToString();
                    lblcontectddress.InnerText= dt.Rows[0]["CompanyAddress"].ToString();
                    lblcontectddresstop.InnerText= dt.Rows[0]["CompanyAddress"].ToString();
                    //logo2image.ImageUrl = baseurl + logoimg.Replace("~", "");
                    imglogo.ImageUrl = baseurl + logoimg.Replace("~", "");
                    instalink.HRef = dt.Rows[0]["InstagramLink"].ToString();
                    twitterlink.HRef = dt.Rows[0]["TwitterLink"].ToString();
                    youtubelink.HRef = dt.Rows[0]["LinkdinLink"].ToString();
                    facebooklink.HRef = dt.Rows[0]["FacebookLink"].ToString();

                }
                else
                {
                    imglogo.ImageUrl = "img/logo.png";
                    lblcontectddress.InnerText = "Sector - 15,Noida(201301)";
                    lblcontentno.InnerText = "9798 501 225";
                    lblcontectemail.InnerText = "Youremail.com";
                    //logo2image.ImageUrl = "img/logo.png";
                }
            }
            catch (Exception ex)
            {

            }
        }


        protected void GetService()
        {
            DataTable servicesTable = clsmain.GetServiceData();

            // Generate list items for the "Services" dropdown
            foreach (DataRow row in servicesTable.Rows)
            {
                string serviceName = row["ServiceName"].ToString();
                string serviceUrl = row["PageUrl"].ToString();

                HtmlGenericControl div = new HtmlGenericControl("Div");
                HtmlAnchor a = new HtmlAnchor();

                a.HRef = serviceUrl;
                a.InnerText = serviceName;
                a.Attributes["class"] = "dropdown-item";

                div.Controls.Add(a);
                serviceList.Controls.Add(div);
            }
        }

        protected void GetProduct()
        {
            DataTable servicesTable = clsmain.GetProductData();

            // Generate list items for the "Services" dropdown
            foreach (DataRow row in servicesTable.Rows)
            {
                string serviceName = row["ProductName"].ToString();
                string serviceUrl = row["PageUrl"].ToString();

                HtmlGenericControl div = new HtmlGenericControl("Div");
                HtmlAnchor a = new HtmlAnchor();

                a.HRef = serviceUrl;
                a.InnerText = serviceName;
                a.Attributes["class"] = "dropdown-item";
                div.Controls.Add(a);
                ProductList.Controls.Add(div);
            }
        }
    }
}