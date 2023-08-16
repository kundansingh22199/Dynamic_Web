<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="PrivacyPolicy.aspx.cs" Inherits="Dynamic_Web.PrivacyPolicy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!-- Page Header Start -->
    <div class="container-fluid page-header py-5 mb-5">
        <div class="container py-5">
            <h1 class="display-3 text-white mb-3 animated slideInDown">PRIVACY POLICY</h1>
            <nav aria-label="breadcrumb animated slideInDown">
                <ol class="breadcrumb">
                    <li class="breadcrumb-item"><a class="text-white" href="Default.aspx">HOME</a></li>
                    <li class="breadcrumb-item text-white active" aria-current="page">PRIVACY POLICY</li>
                </ol>
            </nav>
        </div>
    </div>
    <!-- Page Header End -->


    <section class="our-history w3l-about-2 py-2">
        <div class="container overflow-auto">
            <div class="container">
                <div class="row">
                    <h4 runat="server" id="section1heading"></h4>
                    <p runat="server" id="section1para">
                    </p>
                    <h5 runat="server" id="section2heading"></h5>
                    <p runat="server" id="section2para1"></p>

                    <p runat="server" id="section2para2"></p>
                    <p runat="server" id="section2para3"></p>
                    <p runat="server" id="section2para4"></p>
                </div>
                <br />
                <div class="row">
                    <p runat="server" id="section2para5"></p>
                    <p runat="server" id="section2para6">
                       
                    </p>
                    <p runat="server" id="section2para7">
                    </p>
                    <p runat="server" id="section2para8"></p>
                    
                    <br />
                    <br />
                    <div>
                        <h4 runat="server" id="section3heading"></h4>
                        <p runat="server" id="section3para"></p>
                        <br />
                    </div>
                    
                    <br />
                    <div>
                        <h4 runat="server" id="section4heading" ></h4>
                        <p runat="server" id="section4para"></p>
                    </div>
                    <br />
                    <br />
                    <div>
                        <h4 runat="server" id="section5heading"></h4>
                        <p runat="server" id="section5para"></p>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
