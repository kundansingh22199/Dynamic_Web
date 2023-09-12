<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Dynamic_Web.About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Page Header Start -->
    <div class="container-fluid page-header py-5 mb-5" style="margin-top: 50px">
        <div class="container py-5">
            <h1 class="display-3 text-white mb-3 animated slideInDown">ABOUT US</h1>
            <nav aria-label="breadcrumb animated slideInDown">
                <ol class="breadcrumb">
                    <li class="breadcrumb-item"><a class="text-white" href="Default.aspx">HOME</a></li>
                    <li class="breadcrumb-item text-white active" aria-current="page">ABOUT US</li>
                </ol>
            </nav>
        </div>
    </div>
    <!-- Page Header End -->


    <!-- About Start -->
    <div class="container-fluid overflow-hidden my-2 px-lg-6">
        <div class="section-title text-center">
             <h1 class="display-5 mb-4 text-center" runat="server" id="lblAboutText">About Us</h1>
            <hr />
        </div>
        <div class="container about px-lg-1">
            <div class="row g-0 mx-lg-1">
                <div class="col-lg-6 ps-lg-1"">
                    <div class="position-relative h-100">
                        <asp:Image ID="ImageAbout" class="position-relative img-fluid w-90" src="img/AEPS/about.jpg" style="background-size: cover;border-radius:15px; height:400px"  runat="server" />
                    </div>
                </div>
                <div class="col-lg-6 about-text wow fadeIn" data-wow-delay="0.5s">
                    <div class="p-lg-2 pe-lg-1">
                        <div class="section-title text-start">
                            <h1 class="display-5 mb-4" runat="server" id="lblAboutText2"></h1>
                        </div>
                        <p class="mb-4 pb-2" runat="server" id="lblAboutContent1"></p>
                        <div class="row g-4 mb-2 pb-2">

                            <p class="mb-4" runat="server" id="lblAboutContent2"></p>
                           
                        </div>
                        <a href="#" class="btn btn-primary py-3 px-5" style="border-radius:15px" runat="server" id="btnAbout">Explore More</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- About End -->
    <!-- Feature Start -->
    <<div class="container-fluid overflow-hidden my-1 px-lg-1">
        <div class="container-fluid overflow-hidden my-1 px-lg-1">
            <div class="container about px-lg-1">
                <div class="section-title text-center">
                    <h1 class="display-5 mb-4 text-center">Why Choose Us</h1>
                    <hr />
                </div>
                <div class="row g-0 mx-lg-1">
                    <div class="col-lg-6 about-text py-5 wow fadeIn" data-wow-delay="0.5s">
                        <div class="p-lg-5 pe-lg-0">
                            <div class="section-title text-start">
                            </div>
                            <p class="mb-2 pb-1" runat="server" id="WhyUs3paragraph1"></p>
                            <p class="mb-2 pb-1" runat="server" id="WhyUs3paragraph2"></p>

                            <div class="row g-4 mb-4 pb-2">
                                <p class="mb-2 pb-1" runat="server" id="WhyUs3paragraph3"></p>
                                <p class="mb-2 pb-1" runat="server" id="WhyUs3paragraph4"></p>
                                <p class="mb-2 pb-1" runat="server" id="WhyUs3paragraph5"></p>
                                <a href="#" class="btn btn-light py-md-3 px-md-5 animated slideInRight" id="WhyUs3buttomlink" runat="server">Why Us</a>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-6 about-image py-5 wow fadeIn" data-wow-delay="1s">
                        <div class="p-lg-5 pe-lg-0">
                            <asp:Image ID="WhyUs3Img" class="img-fluid" Style="background-size: cover; border-radius: 15px; width: 100%; height: 400px" alt="" runat="server" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Feature End -->
    <section>
        <div class="container">
            <div class="section-title text-center">
                <h1 class="display-5 mb-5" style="text-align: center"><strong runat="server" id="OurMissionHeading">OUR MISSION</strong> </h1>
                <hr />
            </div>
            <div class="about2-content-top">
                <div class="row">
                    <div class="col-md-12 col-sm-12">
                        <div class="home-aboutus-content">


                            <div class="row">
                                <div class="col-lg-6 mabtbx align-self-baseline" data-aos="zoom-in" data-aos-delay="100">
                                    <asp:Image ID="OurMissionImage" alt="" class="img-fluid" src="img/AEPS/mission.jpg" Style="width: 100%; height: 100%; margin-top: 10px; margin-left: -20px;" runat="server" />
                                </div>
                                <div class="col-lg-6 pt-3 pt-lg-2 content">
                                    <p class="font-italic">
                                        <strong runat="server" id="OurMissionHeading2"></strong>
                                    </p>

                                    <p runat="server" id="OurMissionParagraph1"></p>

                                    <p runat="server" id="OurMissionParagraph2"></p>
                                </div>
                            </div>
                            <p>
                                &nbsp;
                           
                            </p>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- Team Start -->
    <div class="container-xxl py-5">
        <div class="container" style="text-align: center;">
            <div class="section-title text-center">
                <h1 class="display-5 mb-5" runat="server" id="lblTeamHeader">OUR TEAM MEMBERS</h1>
                <hr />
            </div>
            <div class="row g-4">
                <div class="col-lg-3 col-md-6 wow fadeInUp" data-wow-delay="0.1s">
                    <div class="team-item">
                        <div class="overflow-hidden position-relative">
                            <asp:Image ID="Image1Team" class="img-fluid" alt="" runat="server" Style="height: 45vh; width: 95%" />
                            <div class="team-social">
                                <a class="btn btn-square" href="" runat="server" id="lblTeamFb1"><i class="fab fa-facebook-f"></i></a>
                                <a class="btn btn-square" href="" runat="server" id="lblTeamtw1"><i class="fab fa-twitter"></i></a>
                                <a class="btn btn-square" href="" runat="server" id="lblTeamtIn1"><i class="fab fa-instagram"></i></a>
                            </div>
                        </div>
                        <div class="text-center border border-5 border-light border-top-0 p-4">
                            <h5 class="mb-0" runat="server" id="lblTeamMember1"></h5>
                            <small runat="server" id="lblTeamRole1"></small>
                        </div>
                    </div>
                </div>
                <div class="col-lg-3 col-md-6 wow fadeInUp" data-wow-delay="0.3s">
                    <div class="team-item">
                        <div class="overflow-hidden position-relative">
                            <asp:Image ID="Image2Team" class="img-fluid" alt="" runat="server" Style="height: 45vh; width: 95%" />
                            <div class="team-social">
                                <a class="btn btn-square" href="" runat="server" id="lblTeamFb2"><i class="fab fa-facebook-f"></i></a>
                                <a class="btn btn-square" href="" runat="server" id="lblTeamtw2"><i class="fab fa-twitter"></i></a>
                                <a class="btn btn-square" href="" runat="server" id="lblTeamtIn2"><i class="fab fa-instagram"></i></a>
                            </div>
                        </div>
                        <div class="text-center border border-5 border-light border-top-0 p-4">
                            <h5 class="mb-0" runat="server" id="lblTeamMember2"></h5>
                            <small runat="server" id="lblTeamRole2"></small>
                        </div>
                    </div>
                </div>
                <div class="col-lg-3 col-md-6 wow fadeInUp" data-wow-delay="0.5s">
                    <div class="team-item">
                        <div class="overflow-hidden position-relative">
                            <asp:Image ID="Image3Team" class="img-fluid" alt="" runat="server" Style="height: 45vh; width: 95%" />
                            <div class="team-social">
                                <a class="btn btn-square" href="" runat="server" id="lblTeamFb3"><i class="fab fa-facebook-f"></i></a>
                                <a class="btn btn-square" href="" runat="server" id="lblTeamtw3"><i class="fab fa-twitter"></i></a>
                                <a class="btn btn-square" href="" runat="server" id="lblTeamtIn3"><i class="fab fa-instagram"></i></a>
                            </div>
                        </div>
                        <div class="text-center border border-5 border-light border-top-0 p-4">
                            <h5 class="mb-0" runat="server" id="lblTeamMember3"></h5>
                            <small runat="server" id="lblTeamRole3"></small>
                        </div>
                    </div>
                </div>
                <div class="col-lg-3 col-md-6 wow fadeInUp" data-wow-delay="0.7s">
                    <div class="team-item">
                        <div class="overflow-hidden position-relative">
                            <asp:Image ID="Image4Team" class="img-fluid" alt="" runat="server" Style="height: 45vh; width: 95%" />
                            <div class="team-social">
                                <a class="btn btn-square" href="" runat="server" id="lblTeamFb4"><i class="fab fa-facebook-f"></i></a>
                                <a class="btn btn-square" href="" runat="server" id="lblTeamtw4"><i class="fab fa-twitter"></i></a>
                                <a class="btn btn-square" href="" runat="server" id="lblTeamtIn4"><i class="fab fa-instagram"></i></a>
                            </div>
                        </div>
                        <div class="text-center border border-5 border-light border-top-0 p-4">
                            <h5 class="mb-0" runat="server" id="lblTeamMember4"></h5>
                            <small runat="server" id="lblTeamRole4"></small>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Team End -->

</asp:Content>
