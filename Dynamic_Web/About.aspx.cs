using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Dynamic_Web.App_Code;

namespace Dynamic_Web
{
    public partial class About : System.Web.UI.Page
    {
        string baseurl = "https://localhost:44310";
        ClsTeamMaster clsTeam = new ClsTeamMaster();
        ClsWhyUsMaster clsWhy = new ClsWhyUsMaster();
        ClsAbout clsAbout = new ClsAbout();
        ClsMissionMaster clsMission = new ClsMissionMaster();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetWhyUs();
                GetAboutData();
                GetTeamMemberData();
                GetMissionData();
            }
        }

        public void GetAboutData()
        {
            try
            {
                DataTable dt = clsAbout.GetAboutData();
                if (dt.Rows.Count > 0)
                {

                    string homesection3image = dt.Rows[0]["image"].ToString();
                    ImageAbout.ImageUrl = baseurl + homesection3image.Replace("~", "");

                    lblAboutText.InnerText = dt.Rows[0]["Heading"].ToString();
                    lblAboutText2.InnerText = dt.Rows[0]["Heading"].ToString();
                    //HomesectionContant.InnerText = dt.Rows[0][""].ToString();
                    lblAboutContent1.InnerText = dt.Rows[0]["Content1"].ToString();
                    lblAboutContent2.InnerText = dt.Rows[0]["content2"].ToString();
                    btnAbout.HRef = dt.Rows[0]["ButtonLink"].ToString();
                }
                else
                {
                    ImageAbout.ImageUrl = "img/AEPS/about.jpg";
                    lblAboutText.InnerText = "About Us";
                    lblAboutContent1.InnerText = "Our company is your one stop solution for all needs. There is no doubt that we are the leaders and you don't have to worry about our image because it is perfect.";
                    lblAboutContent1.InnerText = "Our company is your one stop solution for all needs. There is no doubt that we are the leaders and you don't have to worry about our image because it is perfect.";
                    btnAbout.HRef = "";
                }
            }
            catch (Exception ex)
            {

            }
        }
        public void GetWhyUs()
        {
            try
            {
                DataTable dt = clsWhy.GetWhyUs();
                if (dt.Rows.Count > 0)
                {
                    string homesection3image = dt.Rows[0]["ImageWhyUs"].ToString();
                    WhyUs3Img.ImageUrl = baseurl + homesection3image.Replace("~", "");

                    WhyUs3paragraph1.InnerText = dt.Rows[0]["ContentFirst"].ToString();
                    WhyUs3paragraph2.InnerText = dt.Rows[0]["ContentSecound"].ToString();
                    WhyUs3paragraph3.InnerText = dt.Rows[0]["ContentThird"].ToString();
                    WhyUs3paragraph4.InnerText = dt.Rows[0]["ContentFouth"].ToString();
                    WhyUs3paragraph5.InnerText = dt.Rows[0]["ContentFifth"].ToString();
                    WhyUs3buttomlink.HRef = dt.Rows[0]["ButtonLink"].ToString();
                }
                else
                {


                    WhyUs3Img.ImageUrl = "assets/images/About_img.png";
                    //WhyUs3heading.InnerText = "Why Us?";
                    //WhyUsContant.InnerText = " Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do<br>eiusmod tempor incididunt ut labore et dolore magna aliqua.";
                    WhyUs3paragraph1.InnerText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do < br >eiusmod tempor.";
                    WhyUs3paragraph2.InnerText = "sed do eiusmod tempor incididunt ut labore et dolore magna<br>aliqua  ";
                    WhyUs3paragraph3.InnerText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do < br > eiusmod tempor incididunt ut labore et dolore magna aliqua";
                    WhyUs3paragraph4.InnerText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
                    WhyUs3paragraph5.InnerText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do<br>eiusmod tempor.";
                    WhyUs3buttomlink.HRef = "AboutUs.aspx";
                }
            }
            catch (Exception ex)
            {

            }
        }
        public void GetTeamMemberData()
        {
            try
            {
                DataTable dt = clsTeam.GetTeamMaster();
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count; i++)
                    {
                        if (i == 0)
                        {
                            string Section4TeamImage1 = baseurl + dt.Rows[i]["ProfileImg"].ToString();
                            Image1Team.ImageUrl = Section4TeamImage1.Replace("~", "");
                            lblTeamMember1.InnerText = dt.Rows[i]["Name"].ToString();
                            lblTeamRole1.InnerText = dt.Rows[i]["RoleType"].ToString();
                            lblTeamFb1.HRef = dt.Rows[i]["SocialMdaLink1"].ToString();
                            lblTeamtw1.HRef = dt.Rows[i]["SocialMdaLink2"].ToString();
                            lblTeamtIn1.HRef = dt.Rows[i]["SocialMdaLink3"].ToString();
                        }
                        //else
                        //{
                        //    AboutSection4TeamImage1.ImageUrl = "assets/images/t1.png";
                        //    namecard1.InnerText = "Max Willam";
                        //    jobtitlecard1.InnerText = "VICE PRINCIPAL";
                        //}
                        if (i == 1)
                        {
                            string Section4TeamImage2 = baseurl + dt.Rows[i]["ProfileImg"].ToString();
                            Image2Team.ImageUrl = Section4TeamImage2.Replace("~", "");
                            lblTeamMember2.InnerText = dt.Rows[i]["Name"].ToString();
                            lblTeamRole2.InnerText = dt.Rows[i]["RoleType"].ToString();
                            lblTeamFb2.HRef = dt.Rows[i]["SocialMdaLink1"].ToString();
                            lblTeamtw2.HRef = dt.Rows[i]["SocialMdaLink2"].ToString();
                            lblTeamtIn2.HRef = dt.Rows[i]["SocialMdaLink3"].ToString();
                        }
                        //else
                        //{
                        //    AboutSection4TeamImage2.ImageUrl = "assets/images/t2.png";
                        //    namecard2.InnerText = "Max Willam";
                        //    jobtitlecard2.InnerText = "VICE PRINCIPAL";
                        //}
                        if (i == 2)
                        {
                            string Section4TeamImage3 = baseurl + dt.Rows[i]["ProfileImg"].ToString();
                            Image3Team.ImageUrl = Section4TeamImage3.Replace("~", "");
                            lblTeamMember3.InnerText = dt.Rows[i]["Name"].ToString(); ;
                            lblTeamRole3.InnerText = dt.Rows[i]["RoleType"].ToString();
                            lblTeamFb3.HRef = dt.Rows[i]["SocialMdaLink1"].ToString();
                            lblTeamtw3.HRef = dt.Rows[i]["SocialMdaLink2"].ToString();
                            lblTeamtIn3.HRef = dt.Rows[i]["SocialMdaLink3"].ToString();
                        }
                        //else
                        //{
                        //    AboutSection4TeamImage3.ImageUrl = "assets/images/t3.png";
                        //    namecard3.InnerText = "Max Willam";
                        //    jobtitlecard3.InnerText = "VICE PRINCIPAL";
                        //}
                        if (i == 3)
                        {
                            string Section4TeamImage4 = baseurl + dt.Rows[i]["ProfileImg"].ToString();
                            Image4Team.ImageUrl = Section4TeamImage4.Replace("~", "");
                            lblTeamMember4.InnerText = dt.Rows[i]["Name"].ToString(); ;
                            lblTeamRole4.InnerText = dt.Rows[i]["RoleType"].ToString();
                            lblTeamFb4.HRef = dt.Rows[i]["SocialMdaLink1"].ToString();
                            lblTeamtw4.HRef = dt.Rows[i]["SocialMdaLink2"].ToString();
                            lblTeamtIn4.HRef = dt.Rows[i]["SocialMdaLink3"].ToString();
                        }
                        //else
                        //{
                        //    AboutSection4TeamImage4.ImageUrl = "assets/images/t4.png";
                        //    namecard4.InnerText = "Max Willam";
                        //    jobtitlecard4.InnerText = "VICE PRINCIPAL";
                        //}


                        //if (i == 4)
                        //{
                        //    string Section4TeamImage5 = baseurl + dt.Rows[i]["ProfileImg"].ToString();
                        //    AboutSection4TeamImage5.ImageUrl = Section4TeamImage5.Replace("~", "");
                        //    namecard5.InnerText = dt.Rows[i]["Name"].ToString(); ;
                        //    jobtitlecard5.InnerText = dt.Rows[i]["RoleType"].ToString(); ;
                        //}


                        //else
                        //{
                        //    AboutSection4TeamImage4.ImageUrl = "assets/images/t5.png";
                        //    namecard5.InnerText = "Max Willam";
                        //    jobtitlecard5.InnerText = "VICE PRINCIPAL";
                        //}
                    }

                }

            }
            catch (Exception ex)
            {

            }
        }
        public void GetMissionData()
        {
            try
            {
                DataTable dt = clsMission.GetOurMission();
                if (dt.Rows.Count > 0)
                {
                    string aboutsection3image = baseurl + dt.Rows[0]["IamgeOurMission"].ToString();
                    OurMissionImage.ImageUrl = aboutsection3image.Replace("~", "");
                    //AboutSection2heading.InnerText = dt.Rows[0][""].ToString();
                    OurMissionParagraph1.InnerText = dt.Rows[0]["ContentFirst"].ToString();
                    OurMissionParagraph2.InnerText = dt.Rows[0]["ContentSecond"].ToString();

                }
                else
                {
                    OurMissionImage.ImageUrl = "img/AEPS/mission.jpg";
                    OurMissionParagraph1.InnerText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ligula ullamcorper malesuada proin libero nunc consequat interdum varius sit. Porta non pulvinar neque laoreet suspendisse. Lorem ipsum dolor sit amet consectetur adipiscing elit pellentesque. A diam sollicitudin tempor id eu nisl.Porta non pulvinar neque laoreet suspendisse.";
                    OurMissionParagraph2.InnerText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";


                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}