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
    public partial class Default : System.Web.UI.Page
    {
        string baseurl = "https://localhost:44310";
        //string baseurl = "http://admin.zappay.in";
        ClsSliderMaster clsSlider = new ClsSliderMaster();
        ClsTeamMaster clsTeam = new ClsTeamMaster();
        ClsWhyUsMaster clsWhy = new ClsWhyUsMaster();
        ClsAbout clsAbout = new ClsAbout();
        ClsHomeSession clsHome = new ClsHomeSession();
        ClsComunityMaster clsComunity = new ClsComunityMaster();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetSliderData();
                GetCommunityData();
                GetAboutData();
                GetServiceData();
                GetWhyUs();
                GetTeamMemberData();
                GetTestimonial();
                SliderActiveDeactive();
            }
        }

        public void SliderActiveDeactive()
        {
            DataTable dt = clsSlider.GetSliderData();
            if (dt.Rows.Count > 0)
            {
                int slider1 = Convert.ToInt32(dt.Rows[0]["Slider1Status"]);
                int slider2 = Convert.ToInt32(dt.Rows[0]["Slider2Status"]);
                int slider3 = Convert.ToInt32(dt.Rows[0]["Slider3Status"]);
                if (slider1 == 1)
                {
                    slider1Id.Visible = true;
                }
                else
                {
                    slider1Id.Visible = false;
                }
                if (slider2 == 1)
                {
                    slider2Id.Visible = true;
                }
                else
                {
                    slider2Id.Visible = false;
                }
                if (slider3 == 1)
                {
                    slider3Id.Visible = true;
                }
                else
                {
                    slider3Id.Visible = false;
                }
            }
        }

        public void GetSliderData()
        {
            try
            {
                DataTable dt = clsSlider.GetSliderData();
                if (dt.Rows.Count > 0)
                {

                    string imgUrlslide1img = dt.Rows[0]["sliderImage1"].ToString();
                    // **************************** Slider first ***************************************
                    string RevertUrl = imgUrlslide1img.Replace("~", "");
                    ImageSlider1.ImageUrl = baseurl + RevertUrl;
                    //slide1heading.InnerText = dt.Rows[0]["sliderHeading1"].ToString();
                    //slider1paragraph.InnerText = dt.Rows[0]["sliderContent1"].ToString();
                    //slider1buttonlink1.HRef = dt.Rows[0]["sliderButton1link1"].ToString();
                    //slider1buttonlink2.HRef = dt.Rows[0]["sliderButton2link1"].ToString();
                    // **************************** Slider Second ***************************************
                    string imgUrlslide2img = dt.Rows[0]["sliderImage2"].ToString();
                    ImageSlider2.ImageUrl = baseurl + imgUrlslide2img.Replace("~", "");
                    //slide2heading.InnerText = dt.Rows[0]["sliderHeading2"].ToString();
                    //slider2paragraph.InnerText = dt.Rows[0]["sliderContent2"].ToString();
                    //slider2buttonlink1.HRef = dt.Rows[0]["sliderButton1link2"].ToString();
                    //slider2buttonlink2.HRef = dt.Rows[0]["sliderButton2link2"].ToString();
                    //======================================= slide3=======================================
                    string slide2image = baseurl + dt.Rows[0]["sliderImage3"].ToString();
                    ImageSlider3.ImageUrl = slide2image.Replace("~", "");
                    //slide3heading.InnerText = dt.Rows[0]["sliderHeading3"].ToString();
                    //slider3paragraph.InnerHtml = dt.Rows[0]["sliderContent3"].ToString();
                    //slider3buttonlink1.HRef = dt.Rows[0]["sliderButton1link3"].ToString();
                    //slider3buttonlink2.HRef = dt.Rows[0]["sliderButton2link3"].ToString();
                }
                else
                {
                    ImageSlider1.ImageUrl = "img/carousel1.png";
                    ImageSlider2.ImageUrl = "img/carousel2.png";
                    ImageSlider3.ImageUrl = "mg/carousel2.png";
                    //slide1heading.InnerText = "DMT";
                    //slide2heading.InnerText = "BBPS";
                    //slide3heading.InnerText = "AEPS";
                    //slider1paragraph.InnerText = "Domestic Money Transfer.";
                    //slider2paragraph.InnerText = "BBPS (BHARAT BILL PAYMENT SYSTEM).";
                    //slider3paragraph.InnerHtml = "AEPS - Aadhar and Biomatric Base Payment Service.";
                    //slider1buttonlink1.HRef = "Explore More";
                    //slider1buttonlink2.HRef = "Contact us";
                    //slider2buttonlink1.HRef = "Explore More";
                    //slider2buttonlink2.HRef = "Contact us";
                    //slider3buttonlink1.HRef = "Explore More";
                    //slider3buttonlink2.HRef = "Contact us";



                }
            }
            catch (Exception ex)
            {

            }
        }

        public void GetCommunityData()
        {
            try
            {
                DataTable dt = clsComunity.GetCommunityMaster();
                if (dt.Rows.Count > 0)
                {

                    string homeSection2image1 = dt.Rows[0]["communityimage1"].ToString();
                    HomeSection2img1.ImageUrl = baseurl + homeSection2image1.Replace("~", "");

                    string homesection2image3 = dt.Rows[0]["communityimage3"].ToString();
                    HomeSection2img3.ImageUrl = baseurl + homesection2image3.Replace("~", "");
                    string homesection2image2 = dt.Rows[0]["communityimage2"].ToString();
                    HomeSection2img2.ImageUrl = baseurl + homesection2image2.Replace("~", "");
                    homeSection2Heading.InnerText = dt.Rows[0]["heading"].ToString();
                    homeSection2paragraph.InnerText = dt.Rows[0]["content"].ToString();
                    btnlink.HRef = dt.Rows[0]["buttonlink"].ToString();
                }
                else
                {


                    HomeSection2img1.ImageUrl = "img/team-2.jpg";
                    HomeSection2img3.ImageUrl = "img/team-2.jpg";
                    HomeSection2img2.ImageUrl = "img/team-2.jpg";
                    homeSection2Heading.InnerText = "Join The Biggest Community <br> Of Learning";
                    homeSection2paragraph.InnerText = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...<br>There is no one who loves pain itself, who seeks after it and wants to have it, simply because it is pain...";
                    btnlink.HRef = "";
                }
            }
            catch (Exception ex)
            {

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

        public void GetServiceData()
        {
            try
            {
                DataTable dt = clsHome.GetHomeSection3();
                if (dt.Rows.Count > 0)
                {
                    string S3Div1 = baseurl + dt.Rows[0]["Div1image"].ToString();
                    string S3Div2 = baseurl + dt.Rows[0]["Div2image"].ToString();
                    string S3Div3 = baseurl + dt.Rows[0]["Div3image"].ToString();
                    string S3Div4 = baseurl + dt.Rows[0]["Div4image"].ToString();
                    string S3Div5 = baseurl + dt.Rows[0]["Div5image"].ToString();
                    string S3Div6 = baseurl + dt.Rows[0]["Div6image"].ToString();
                    Div1image.ImageUrl = S3Div1.Replace("~", "");
                    Div2image.ImageUrl = S3Div2.Replace("~", "");
                    Div3image.ImageUrl = S3Div3.Replace("~", "");
                    Div4image.ImageUrl = S3Div4.Replace("~", "");
                    Div5image.ImageUrl = S3Div4.Replace("~", "");
                    Div6image.ImageUrl = S3Div4.Replace("~", "");
                    Div1heading.InnerText = dt.Rows[0]["Div1Heading"].ToString();
                    Div2heading.InnerText = dt.Rows[0]["Div2Heading"].ToString();
                    Div3heading.InnerText = dt.Rows[0]["Div3Heading"].ToString();
                    Div4heading.InnerText = dt.Rows[0]["Div4Heading"].ToString();
                    Div5heading.InnerText = dt.Rows[0]["Div5Heading"].ToString();
                    Div6heading.InnerText = dt.Rows[0]["Div6Heading"].ToString();
                    section3Heading.InnerText = dt.Rows[0]["Section3Heading"].ToString();
                    //section3content.InnerText = dt.Rows[0]["Section3content"].ToString();
                    Div1content.InnerText = dt.Rows[0]["Div1content"].ToString();
                    Div2content.InnerText = dt.Rows[0]["Div2content"].ToString();
                    Div3content.InnerText = dt.Rows[0]["Div3content"].ToString();
                    Div4content.InnerText = dt.Rows[0]["Div4content"].ToString();
                    Div5content.InnerText = dt.Rows[0]["Div5content"].ToString();
                    Div6content.InnerText = dt.Rows[0]["Div6content"].ToString();
                }
                else
                {
                    Div1image.ImageUrl = "img/service-1.jpg";
                    Div2image.ImageUrl = "img/service-2.jpg";
                    Div3image.ImageUrl = "img/service-3.jpg";
                    Div4image.ImageUrl = "img/service-4.jpg";
                    Div5image.ImageUrl = "img/service-5.jpg";
                    Div6image.ImageUrl = "img/service-6.jpg";
                    Div1heading.InnerText = "Service";
                    Div2heading.InnerText = "Service";
                    Div3heading.InnerText = "Service";
                    Div4heading.InnerText = "Service";
                    Div5heading.InnerText = "Service";
                    Div6heading.InnerText = "Service";
                    section3Heading.InnerText = "Our Services";
                    //section3content.InnerText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.At elementum eu facilisis sed odio morbi quis commodo odio.";
                    Div1content.InnerText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. At elementum eu facilisis sed odio morbi quis commodo odio. ";
                    Div2content.InnerText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. At elementum eu facilisis sed odio morbi quis commodo odio.";
                    Div3content.InnerText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. At elementum eu facilisis sed odio morbi quis commodo odio";
                    Div4content.InnerText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. At elementum eu facilisis sed odio morbi quis commodo odio";
                    Div5content.InnerText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. At elementum eu facilisis sed odio morbi quis commodo odio";
                    Div6content.InnerText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. At elementum eu facilisis sed odio morbi quis commodo odio";
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

        public void GetTestimonial()
        {
            try
            {
                DataTable dt = clsHome.GetHomeSection4();
                if (dt.Rows.Count > 0)
                {
                    string Div1image = baseurl + dt.Rows[0]["Div1image"].ToString();
                    string Div2image = baseurl + dt.Rows[0]["Div2image"].ToString();
                    string Div3image = baseurl + dt.Rows[0]["Div3image"].ToString();
                    TestmonialImage1.ImageUrl = Div1image.Replace("~", "");
                    TestmonialImage2.ImageUrl = Div2image.Replace("~", "");
                    TestmonialImage3.ImageUrl = Div3image.Replace("~", "");

                    TestmonialHeader.InnerText = dt.Rows[0]["Section4Heading"].ToString();
                    //Section4content.InnerText = dt.Rows[0]["Section4Content"].ToString();
                    TestmonialHeading1.InnerText = dt.Rows[0]["Div1heading"].ToString();
                    TestmonialHeading2.InnerText = dt.Rows[0]["Div2heading"].ToString();
                    TestmonialHeading3.InnerText = dt.Rows[0]["Div3heading"].ToString();

                    TestmonialContent1.InnerText = dt.Rows[0]["Div1Content"].ToString();
                    TestmonialContent2.InnerText = dt.Rows[0]["Div2Content"].ToString();
                    TestmonialContent3.InnerText = dt.Rows[0]["Div3Content"].ToString();
                }
                else
                {
                    TestmonialImage1.ImageUrl = "img/testimonial-1.jpg";
                    TestmonialImage1.ImageUrl = "img/testimonial-1.jpg";
                    TestmonialImage1.ImageUrl = "img/testimonial-1.jpg";
                    TestmonialHeader.InnerText = "Testimonial";
                    //Section4content.InnerText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod<br>tempor incididunt ut labore et dolore magna aliqua.";
                    TestmonialHeading1.InnerText = "Astha SIngh";
                    TestmonialHeading2.InnerText = "Kundan Singh";
                    TestmonialHeading3.InnerText = "Romi Singh";

                    TestmonialContent1.InnerText = "";
                    TestmonialContent1.InnerText = "";
                    TestmonialContent1.InnerText = "";
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}