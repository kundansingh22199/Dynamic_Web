<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Bbps.aspx.cs" Inherits="Dynamic_Web.Bbps" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Page Header Start -->
    <div class="container-fluid page-header py-5 mb-5">
        <div class="container py-5">
            <h1 class="display-3 text-white mb-3 animated slideInDown">BBPS</h1>
            <nav aria-label="breadcrumb animated slideInDown">
                <ol class="breadcrumb">
                    <li class="breadcrumb-item"><a class="text-white" href="Default.aspx">HOME</a></li>
                    <li class="breadcrumb-item text-white active" aria-current="page">BBPS</li>
                </ol>
            </nav>
        </div>
    </div>
    <!-- Page Header End -->
    <section id="about" class="home-aboutus">
        <div class="container">
            <div class="">
                <div class="row">
                    <div class="col-md-12 col-sm-12">
                        <div class="">
                            <h2 ><strong runat="server" id="bbpsHeading"></strong> </h2>
                           
                            <div class="row">
                                <div class="col-lg-6 mabtbx align-self-baseline" data-aos="zoom-in" data-aos-delay="100">
                                    <asp:Image ID="bbpsImage" runat="server" class="img-fluid" style="width: 100%; height:100%; margin-top:10px; margin-left:-50px;" alt="" />
                                </div>
                                <div class="col-lg-6 pt-3 pt-lg-6 content" ">
                                  <p class="font-italic">
                                      <strong runat="server" id="bbpsHeading1">:-</strong> 
                                    </p>
                                  
                                    <p runat="server" id="bbpsContent"></p>
                                 
                                    <p runat="server" id="bbpsParagraph1"></p>
                                    <p runat="server" id="bbpsParagraph2"></p>
                                    <p runat="server" id="bbpsParagraph3"></p>
                                    <p runat="server" id="bbpsParagraph4"></p>
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
</asp:Content>
