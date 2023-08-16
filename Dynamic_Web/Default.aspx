<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Dynamic_Web.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Carousel Start -->
    <div class="container-fluid p-0 pb-5"  style="position:relative;">
        <div class="owl-carousel header-carousel position-relative">
            <div class="owl-carousel-item position-relative" runat="server" id="slider1Id" style="">
                <asp:Image ID="ImageSlider1" class="img-fluid" alt="" style="height:500px"  runat="server" />
                <div class="position-absolute top-0 start-0 w-100 h-100 d-flex align-items-center" style="color:black">
                    <div class="container">
                        <div class="row justify-content-left">
                            <div class="col-12 col-lg-8 text-center" style="color:black;margin-left:-140px">
                                <h1 class="display-3 animated slideInDown mb-4" id="slide1heading" runat="server"  style="color:black"></h1>
                                <p class="fs-5 fw-medium mb-4 pb-2" runat="server" id="slider1paragraph"  style="color:black"></p>
                                <a href="#" class="btn btn-primary py-md-3 px-md-5 me-3 animated slideInLeft" id="slider1buttonlink1" runat="server">Explore More</a>
                                <a href="#" class="btn btn-light py-md-3 px-md-5 animated slideInRight" id="slider1buttonlink2" runat="server">Contact us</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="owl-carousel-item position-relative"  runat="server" id="slider2Id" style="">
                <asp:Image ID="ImageSlider2" class="img-fluid" alt="" style="height:500px"  runat="server" />
                <div class="position-absolute top-0 start-0 w-100 h-100 d-flex align-items-center" style="color:black">
                    <div class="container">
                        <div class="row justify-content-left">
                            <div class="col-12 col-lg-8 text-center" style="color:black;margin-left:-140px">
                                <h1 class="display-3 animated slideInDown mb-4" id="slide2heading" runat="server" style="color:black"></h1>
                                <p class="fs-5 fw-medium mb-4 pb-2" runat="server" id="slider2paragraph" style="color:black"></p>
                                <a href="#" class="btn btn-primary py-md-3 px-md-5 me-3 animated slideInLeft" id="slider2buttonlink1" runat="server">Explore More</a>
                                <a href="#" class="btn btn-light py-md-3 px-md-5 animated slideInRight" id="slider2buttonlink2" runat="server">Contact us</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="owl-carousel-item position-relative" runat="server" id="slider3Id" style="">
                <asp:Image ID="ImageSlider3" class="img-fluid" alt="" style="height:500px"  runat="server" />
                <div class="position-absolute top-0 start-0 w-100 h-100 d-flex align-items-center" style="color:black">
                    <div class="container">
                        <div class="row justify-content-left">
                            <div class="col-12 col-lg-8 text-center" style="color:black;margin-left:-140px">
                                <h1 class="display-3 animated slideInDown mb-4" id="slide3heading" runat="server"  style="color:black"></h1>
                                <p class="fs-5 fw-medium mb-4 pb-2" runat="server" id="slider3paragraph" style="color:black"></p>
                                <a href="#" class="btn btn-primary py-md-3 px-md-5 me-3 animated slideInLeft" id="slider3buttonlink1" runat="server">Explore More</a>
                                <a href="#" class="btn btn-light py-md-3 px-md-5 animated slideInRight" id="slider3buttonlink2" runat="server">Contact us</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Carousel End -->


    <section class="container-fluid join py-5">
        <div class="row">
            <div class="col-lg-12 col-sm-12">
                <h1 id="homeSection2Heading" class="text-center mt-5 pt-3 head_text" style="margin-top: 10%;" runat="server"></h1>
            </div>
            <div class="col-lg-12 col-sm-12">
                <p id="homeSection2paragraph" class="text-center px-5 mt-1" runat="server"></p>
            </div>
        </div>
        <div class="row g-4">
                <div class="col-lg-4 col-md-6 wow fadeInUp" data-wow-delay="0.3s">
                    <div class="team-item">
                        <div class="overflow-hidden position-relative w-90 h-90">
                            <asp:Image ID="HomeSection2img1"  AlternateText="Error" class="img-fluid  w-90 h-90" style="height:80%;width:80%;margin-left:50px;" runat="server" />
                        </div>
                    </div>
                </div>
                <div class="col-lg-4 col-md-6 wow fadeInUp" data-wow-delay="0.5s">
                    <div class="team-item">
                        <div class="overflow-hidden position-relative w-90 h-90">
                            <asp:Image ID="HomeSection2img2"  AlternateText="Error" class="img-fluid  w-90 h-90" style="height:80%;width:80%;margin-left:50px;" runat="server" />
                        </div>
                    </div>
                </div>
                <div class="col-lg-4 col-md-6 wow fadeInUp" data-wow-delay="0.7s">
                    <div class="team-item">
                        <div class="overflow-hidden position-relative w-90 h-90">
                            <asp:Image ID="HomeSection2img3"  AlternateText="Error" class="img-fluid  w-90 h-90" style="height:80%;width:80%;margin-left:50px;" runat="server" />
                        </div>
                    </div>
                </div>
            <center><a href="#" id="btnlink" class="btn btn-primary py-3 px-5" style="width:200px;border-radius:15px;margin-top:30px" runat="server">Learn More</a></center>
            </div>
    </section>


    <!-- About Start -->
    <div class="container-fluid overflow-hidden my-5 px-lg-0">
        <div class="section-title text-center">
             <h1 class="display-5 mb-4 text-center" runat="server" id="lblAboutText">About Us</h1>
        </div>
        <div class="container about px-lg-0">
            <div class="row g-0 mx-lg-0">
                <div class="col-lg-6 ps-lg-0" style="min-height: 400px;">
                    <div class="position-relative h-100">
                        <asp:Image ID="ImageAbout" class="position-absolute img-fluid w-90 h-90" src="img/AEPS/about.jpg" style="object-fit: cover; margin-top:50px;border-radius:15px"  runat="server" />
                    </div>
                </div>
                <div class="col-lg-6 about-text py-5 wow fadeIn" data-wow-delay="0.5s">
                    <div class="p-lg-5 pe-lg-0">
                        <div class="section-title text-start">
                            <h1 class="display-5 mb-4" runat="server" id="lblAboutText2"></h1>
                        </div>
                        <p class="mb-4 pb-2" runat="server" id="lblAboutContent1"></p>
                        <div class="row g-4 mb-4 pb-2">

                            <p class="mb-4 pb-2" runat="server" id="lblAboutContent2"></p>
                           
                        </div>
                        <a href="#" class="btn btn-primary py-3 px-5" style="border-radius:15px" runat="server" id="btnAbout">Explore More</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- About End -->


    <!-- Service Start -->
    <div class="container-xxl py-5">
        <div class="container">
            <div class="section-title text-center">
                <h1 class="display-5 mb-5" runat="server" id="section3Heading"></h1>
            </div>
            <div class="row g-4">
                <div class="col-md-6 col-lg-4 wow fadeInUp" data-wow-delay="0.1s">
                    <div class="service-item">
                        <div class="overflow-hidden">
                            <asp:Image ID="Div1image" class="img-fluid" runat="server" />
                        </div>
                        <div class="p-4 text-center border border-5 border-light border-top-0">
                            <h4 class="mb-3" runat="server" id="Div1heading"></h4>
                            <p runat="server" id="Div1content"></p>
                            <a class="fw-medium" href="">Read More<i class="fa fa-arrow-right ms-2"></i></a>
                        </div>
                    </div>
                </div>
                <div class="col-md-6 col-lg-4 wow fadeInUp" data-wow-delay="0.3s">
                    <div class="service-item">
                        <div class="overflow-hidden">
                            <asp:Image ID="Div2image" class="img-fluid" runat="server" />
                        </div>
                        <div class="p-4 text-center border border-5 border-light border-top-0">
                            <h4 class="mb-3" runat="server" id="Div2heading"></h4>
                            <p runat="server" id="Div2content"></p>
                            <a class="fw-medium" href="">Read More<i class="fa fa-arrow-right ms-2"></i></a>
                        </div>
                    </div>
                </div>
                <div class="col-md-6 col-lg-4 wow fadeInUp" data-wow-delay="0.5s">
                    <div class="service-item">
                        <div class="overflow-hidden">
                            <asp:Image ID="Div3image" class="img-fluid" runat="server" />
                        </div>
                        <div class="p-4 text-center border border-5 border-light border-top-0">
                            <h4 class="mb-3" runat="server" id="Div3heading"></h4>
                            <p runat="server" id="Div3content"></p>
                            <a class="fw-medium" href="" >Read More<i class="fa fa-arrow-right ms-2"></i></a>
                        </div>
                    </div>
                </div>
                <div class="col-md-6 col-lg-4 wow fadeInUp" data-wow-delay="0.1s">
                    <div class="service-item">
                        <div class="overflow-hidden">
                            <asp:Image ID="Div4image" class="img-fluid" runat="server" />
                        </div>
                        <div class="p-4 text-center border border-5 border-light border-top-0">
                            <h4 class="mb-3" runat="server" id="Div4heading"></h4>
                            <p runat="server" id="Div4content"></p>
                            <a class="fw-medium" href="">Read More<i class="fa fa-arrow-right ms-2"></i></a>
                        </div>
                    </div>
                </div>
                <div class="col-md-6 col-lg-4 wow fadeInUp" data-wow-delay="0.3s">
                    <div class="service-item">
                        <div class="overflow-hidden">
                            <asp:Image ID="Div5image" class="img-fluid" runat="server" />
                        </div>
                        <div class="p-4 text-center border border-5 border-light border-top-0">
                            <h4 class="mb-3" runat="server" id="Div5heading"></h4>
                            <p runat="server" id="Div5content"></p>
                            <a class="fw-medium" href="">Read More<i class="fa fa-arrow-right ms-2"></i></a>
                        </div>
                    </div>
                </div>
                <div class="col-md-6 col-lg-4 wow fadeInUp" data-wow-delay="0.5s">
                    <div class="service-item">
                        <div class="overflow-hidden">
                            <asp:Image ID="Div6image" class="img-fluid" runat="server" />
                        </div>
                        <div class="p-4 text-center border border-5 border-light border-top-0">
                            <h4 class="mb-3" runat="server" id="Div6heading"></h4>
                            <p runat="server" id="Div6content"></p>
                            <a class="fw-medium" href="">Read More<i class="fa fa-arrow-right ms-2"></i></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Service End -->


    <!-- Feature Start -->
    <<div class="container-fluid overflow-hidden my-5 px-lg-0">
         <div class="container-fluid overflow-hidden my-5 px-lg-0">
        <div class="container about px-lg-0">
            <div class="section-title text-center">
             <h1 class="display-5 mb-4 text-center" >Why Choose Us</h1>
        </div>
            <div class="row g-0 mx-lg-0">
                 <div class="col-lg-6 about-text py-5 wow fadeIn" data-wow-delay="0.5s" style="margin-top:0px;">
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
                <div class="col-lg-6 ps-lg-0" style="margin-top:50px">
                    <div class="position-relative h-100">
                        <asp:Image ID="WhyUs3Img" class="position-absolute img-fluid w-97 h-97" style="object-fit: cover; border-radius:15px" alt=""  runat="server" />
                    </div>
                </div>
                
            </div>
        </div>
    </div>

    </div>
    <!-- Feature End -->



    <!-- Team Start -->
    <div class="container-xxl py-5">
        <div class="container">
            <div class="section-title text-center">
                <h1 class="display-5 mb-5" runat="server" id="lblTeamHeader"></h1>
            </div>
            <div class="row g-4">
                <div class="col-lg-3 col-md-6 wow fadeInUp" data-wow-delay="0.1s">
                    <div class="team-item">
                        <div class="overflow-hidden position-relative">
                            <asp:Image ID="Image1Team" class="img-fluid" alt=""  runat="server" style="height:300px;width:300px"  />
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
                            <asp:Image ID="Image2Team" class="img-fluid" alt=""  runat="server" style="height:300px;width:300px"  />
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
                            <asp:Image ID="Image3Team" class="img-fluid" alt=""  runat="server" style="height:300px;width:300px"  />
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
                            <asp:Image ID="Image4Team" class="img-fluid" alt=""  runat="server" style="height:300px;width:300px" />
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


    <!-- Testimonial Start -->
    <div class="container-xxl py-5 wow fadeInUp" data-wow-delay="0.1s">
        <div class="container">
            <div class="section-title text-center">
                <h1 class="display-5 mb-5" runat="server" id="TestmonialHeader"></h1>
            </div>
            <div class="owl-carousel testimonial-carousel">
                <div class="testimonial-item text-center">
                    <asp:Image ID="TestmonialImage1" class="img-fluid bg-light p-2 mx-auto mb-3" alt="" style="width: 90px; height: 90px;" runat="server"  />
                    <div class="testimonial-text text-center p-4">
                        <p runat="server" id="TestmonialContent1"></p>
                        <h5 class="mb-1" runat="server" id="TestmonialHeading1"></h5>
                    </div>
                </div>
                <div class="testimonial-item text-center">
                    <asp:Image ID="TestmonialImage2" class="img-fluid bg-light p-2 mx-auto mb-3" alt="" style="width: 90px; height: 90px;" runat="server"  />
                    <div class="testimonial-text text-center p-4">
                        <p runat="server" id="TestmonialContent2"></p>
                        <h5 class="mb-1" runat="server" id="TestmonialHeading2"></h5>
                    </div>
                </div>
                <div class="testimonial-item text-center">
                    <asp:Image ID="TestmonialImage3" class="img-fluid bg-light p-2 mx-auto mb-3" alt="" style="width: 90px; height: 90px;" runat="server"  />
                    <div class="testimonial-text text-center p-4">
                        <p runat="server" id="TestmonialContent3"></p>
                        <h5 class="mb-1" runat="server" id="TestmonialHeading3"></h5>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Testimonial End -->

</asp:Content>
