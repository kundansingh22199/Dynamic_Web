<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Recharge.aspx.cs" Inherits="Dynamic_Web.Recharge" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Page Header Start -->
    <div class="container-fluid page-header py-5 mb-5">
        <div class="container py-5">
            <h1 class="display-3 text-white mb-3 animated slideInDown">RECHARGE</h1>
            <nav aria-label="breadcrumb animated slideInDown">
                <ol class="breadcrumb">
                    <li class="breadcrumb-item"><a class="text-white" href="Default.aspx">HOME</a></li>
                    <li class="breadcrumb-item text-white active" aria-current="page">RECHARGE</li>
                </ol>
            </nav>
        </div>
    </div>
    <!-- Page Header End -->
    <section id="about" class="home-aboutus"  style="background-image:url(../img/kks.png); background-size:cover;width:100%;height:100%">
        <div class="container">
            <div class="about2-content-top">
                <div class="row">
                    <div class="col-md-12 col-sm-12">
                        <div class="home-aboutus-content">
                            <h2 style="text-align:center"><strong>RECHARGE</strong> </h2>
                           <hr />
                            <div class="row">
                                <div class="col-lg-6 mabtbx align-self-baseline" data-aos="zoom-in" data-aos-delay="100">
                                    <asp:Image ID="RechargeImage" runat="server" class=" move-2 img-fluid" style="width: 100%; height:400px; margin-top:10px; " alt="" />
                                </div>
                                <div class="col-lg-6 pt-3 pt-lg-2 content">
                                  <p class="font-italic">
                                      <strong runat="server" id="RechargeSectionHeading">:-</strong> 
                                    </p>
                                  
                                    <p runat="server" id="PreReSectionContent1"></p>
                                    <p runat="server" id="PreReSectionContent2"></p>
                                    <p runat="server" id="PreReSectionContent3"></p>
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
