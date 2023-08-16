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
    public partial class PrivacyPolicy : System.Web.UI.Page
    {
        ClsPrivacyPolicy clsprivacy = new ClsPrivacyPolicy();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetDataPrivacyPolicy();
            }
        }

        public void GetDataPrivacyPolicy()
        {
            try
            {
                DataTable dt = clsprivacy.GetPrivacyPolicy();
                if (dt != null && dt.Rows.Count > 0)
                {
                    section1heading.InnerText = dt.Rows[0]["Section1Heading"].ToString();
                    section1para.InnerText = dt.Rows[0]["Section1para"].ToString();
                    section2heading.InnerText = dt.Rows[0]["Section2heading"].ToString();
                    section2para1.InnerText = dt.Rows[0]["Section2para1"].ToString();
                    section2para2.InnerText = dt.Rows[0]["Section2para2"].ToString();
                    section2para3.InnerText = dt.Rows[0]["Section2para3"].ToString();
                    section2para4.InnerText = dt.Rows[0]["Section2para4"].ToString();
                    section2para5.InnerText = dt.Rows[0]["Section2para5"].ToString();
                    section2para6.InnerText = dt.Rows[0]["Section2para6"].ToString();
                    section2para7.InnerText = dt.Rows[0]["Section2para7"].ToString();
                    section2para8.InnerText = dt.Rows[0]["Section2para8"].ToString();
                    section3heading.InnerText = dt.Rows[0]["Section3heading"].ToString();
                    section3para.InnerText = dt.Rows[0]["Section3para"].ToString();
                    section4heading.InnerText = dt.Rows[0]["Section4heading"].ToString();
                    section4para.InnerText = dt.Rows[0]["Section4para"].ToString();
                    section5heading.InnerText = dt.Rows[0]["Section5heading"].ToString();
                    section5para.InnerText = dt.Rows[0]["Section5para"].ToString();
                }
                else
                {
                    section1heading.InnerText = "Privacy Policy";
                    section1para.InnerText = "This Privacy Policy governs the manner in which <span>Accountpe Pvt. Ltd.</span> collects, uses, maintains and discloses information collected from users (each, a “User”) of the www.accountpe.in website (“Site”). This privacy policy applies to the Site and all products and services offered by <span>Accountpe Pvt. Ltd.</span>";
                    section2heading.InnerText = "We are committed to protect your information from time to time by following :-";
                    section2para1.InnerText = "We constantly update our systems and data to ensure the best possible data security to our customers. In case of any unfortunate incident, we will examine all possible steps with a view to legal proceedings to recover damages against those who responsible.";
                    section2para2.InnerText = "We may collect your personal identification information in a variety of ways, including, but not limited to, when you register on our website or place an order or with other activities, services, features or resources we make available on our Site. You may be asked for, as appropriate, name, email address, phone number, users may, however, visit our site anonymously unless they wish to avail any of our products or services.";
                    section2para3.InnerText = "We will collect personal identification information from Users only if they voluntarily submit such information to us. Users can always refuse to supply personally identification information, except that it may prevent them from engaging in certain Site related activities.";
                    section2para4.InnerText = "Rest assured, we never sell or share user’s personal information to any third party or use e-mail address for unsolicited mail unless explicitly mentioned. Any emails sent by us will only be in reference with the provision of agreed services and products.";
                    section2para5.InnerText = "We may collect non-personal identification information about Users whenever they interact with our Site. Non-personal identification information may include the browser name, the type of computer and technical information about Users means of connection to our Site, such as the operating system and the Internet service providers’ utilized and other similar information. This will be general technology related information and will not affect users.";
                    section2para6.InnerText = " Our Site may use “cookies” to enhance User experience. User’s web browser places cookies on their hard drive for record-keeping purposes and sometimes to track information about them. User may choose to set their web browser to refuse cookies, or to alert you when cookies are being sent. If they do so, note that some parts of the Site may not function properly. We adopt appropriate data collection, storage and processing practices and security measures to protect against unauthorized access, alteration, disclosure or destruction of your personal information, username, password, transaction information and data stored on our Site.";
                    section2para7.InnerText = "Sensitive and private data exchange between the Site and its Users happens over a SSL secured communication channel and is encrypted and protected with digital signatures. Our Site is also in compliance with industry security standards in order to create as secure of an environment as possible for users.";
                    section2para8.InnerText = "You may find advertising or other content on our Site that link to the sites and services of our partners, suppliers, advertisers, sponsors, licensors and other third parties. Please keep in mind that we do not control the content or links that appear on these sites and are not responsible for the practices employed by websites linked to or from our Site. In addition, these sites or services, including their content and links, may be constantly changing. These sites and services may have their own privacy policies and customer service policies. Browsing and interaction on any other website, including websites which have a link to our Site, is subject to that website’s own terms and policies.";
                    section3heading.InnerText = "Contact Us";
                    section3para.InnerText = "If you have any questions or suggestions about our Privacy Policy, do not hesitate to contact us at acntpe@gmail.com";
                    section4heading.InnerText = "Cancellation ( Applicable Before service use )";
                    section4para.InnerText = "In 1 day customers can initiated the cancellation & once cancellation is approved within 3 days refund will be processed and in 7-10 working days amount would be reflected in customer’s bank account";
                    section5heading.InnerText = "Refund ( Applicable After service use )";
                    section5para.InnerText = "In 1 days customers can initiated the Refund & once refund is approved within 3 days refund will be processed and in 7-10 working days amount would be reflected in customer’s bank account";
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}