<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Aeps.aspx.cs" Inherits="Dynamic_Web.Aeps" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Page Header Start -->
    <div class="container-fluid page-header py-5 mb-5">
        <div class="container py-5">
            <h1 class="display-3 text-white mb-3 animated slideInDown">AEPS</h1>
            <nav aria-label="breadcrumb animated slideInDown">
                <ol class="breadcrumb">
                    <li class="breadcrumb-item"><a class="text-white" href="Default.aspx">HOME</a></li>
                    <li class="breadcrumb-item text-white active" aria-current="page">AEPS</li>
                </ol>
            </nav>
        </div>
    </div>
    <!-- Page Header End -->
    <section id="about">
        <div class="container">
            <div class="about2-content-top">
                <div class="row">
                    <div class="col-md-12 col-sm-12">
                            <h2 ><strong>AEPS Service </strong></h2>
                            <div class="row">
                                <div class="col-lg-6 mabtbx align-self-baseline" data-aos="zoom-in" data-aos-delay="100">
                                    <asp:Image ID="AepsSection1Image" runat="server" class="img-fluid" style="width: 100%; height:100%; margin-top:10px; margin-left:-50px;" alt="" />
                                </div>
                                <div class="col-lg-6 pt-3 pt-lg-0 content" style="margin-top:60px;">
                                    <p class="font-italic" >
                                       <strong runat="server" id="AepsSection1heading"></strong>
                                    </p>
                                    <p runat="server" id="AepsSection1Content1">
                                        
                                    </p>
                                    <p class="font-italic" >
                                        <strong>Use of AEPS</strong>
                                    </p>
                                    <ul>
                                        <li runat="server" id="AepsSection1paragraph1"></li>
                                        <li runat="server" id="AepsSection1paragraph2"></li>
                                        <li runat="server" id="AepsSection1paragraph3"></li>
                                    </ul>
                                </div>
                            </div>
                            <p>
                                &nbsp;
                            </p>

                        </div>
                </div>
            </div>
        </div>
    </section>
    <section class="wrapper bg-light" style="
    margin-bottom: 0px;
        margin-top:0px;">
        <div class="container pb-14 pb-md-0 mb-lg-0 mb-xl-0">
            <div class="row gx-lg-8 gx-xl-12 gy-10 align-items-center mb-14">
                <div class="col-lg-6 position-relative">
                    <div class="row gx-md-5 gy-5 position-relative">
                        <div class="col-12">
                            <asp:Image ID="AepsSection2Image" class="img-fluid rounded mb-5 tab_img6" data-cue="fadeIn" data-delay="300" alt="aadhar-money-withdrawal" runat="server" />
                        </div>
                    </div>
                </div>
                <div class="col-lg-6">
                    <h4 class="display-4 mb-5" style="font-size: 1.2rem;" runat="server" id="AepsSection2heading">
                    </h4>

                    <p style="text-align: justify;" runat="server" id="AepsSection2Content1"></p>
                </div>
            </div>
        </div>
    </section>
       <section class="wrapper bg-light ordd" style="
    margin-bottom: 0px; margin-top:0px;
">
        <div class="container pb-14 pb-md-0 mb-lg-0 mb-xl-0">
            <div class="row gx-lg-8 gx-xl-12 gy-10 align-items-center mb-14">
                <div class="col-lg-6 position-relative order-lg-2">
                    <div class="row gx-md-5 gy-5 position-relative">
                        <div class="col-12 mob_aadar_bank_img">
                            <asp:Image ID="AepsSection3Image" runat="server" class="img-fluid rounded mb-5 tab_img4" data-cue="fadeIn" data-delay="300" alt="aadhar-banking" />
                        </div>
                    </div>
                </div>
                <div class="col-lg-6">
                    <h4 class="display-4 mb-5" style="font-size: 1.2rem;" runat="server" id="AepsSection3heading">
                    </h4>
                    <p style="text-align: justify;" runat="server" id="AepsSection3Content1"></p>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
