<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Dmt.aspx.cs" Inherits="Dynamic_Web.Dmt" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Page Header Start -->
    <div class="container-fluid page-header py-5 mb-5">
        <div class="container py-5">
            <h1 class="display-3 text-white mb-3 animated slideInDown">DMT</h1>
            <nav aria-label="breadcrumb animated slideInDown">
                <ol class="breadcrumb">
                    <li class="breadcrumb-item"><a class="text-white" href="Default.aspx">HOME</a></li>
                    <li class="breadcrumb-item text-white active" aria-current="page">DMT</li>
                </ol>
            </nav>
        </div>
    </div>
    <!-- Page Header End -->
    <section id="about" class="home-aboutus" style="background-image:url(../img/kks.png); background-size:cover">
        <div class="container">
            <div class="about2-content-top">
                <div class="row">
                    <div class="col-md-12 col-sm-12">
                        <div class="home-aboutus-content">
                            <h2 style="text-align:center"><strong >DOMESTIC MONEY TRANSFER</strong> </h2>
                           <hr />
                            <div class="row">
                                <div class="col-lg-6 mabtbx align-self-baseline" data-aos="zoom-in" data-aos-delay="100">
                                    <asp:Image  runat="server" ID="DmtImage1" class="img-fluid" style="width: 100%; height:400px; margin-top:10px;" alt="" />
                                </div>
                                <div class="col-lg-6 pt-3 pt-lg-0 content">
                                  <p class="font-italic">
                                      <strong runat="server" id="DmtHeading"></strong> 
                                    </p>
                                  
                                    <p runat="server" id="DmtContent1">
                                    </p>
                                 
                                    <p runat="server" id="DmtContent2">
                                    </p>
                                    <p runat="server" id="DmtContent3">
                                    </p>
                                    <p runat="server" id="DmtContent4">
                                    </p>
                                   
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
