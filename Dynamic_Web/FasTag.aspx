<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="FasTag.aspx.cs" Inherits="Dynamic_Web.FasTag" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Page Header Start -->
    <div class="container-fluid page-header py-5 mb-5">
        <div class="container py-5">
            <h1 class="display-3 text-white mb-3 animated slideInDown">FASTAG</h1>
            <nav aria-label="breadcrumb animated slideInDown">
                <ol class="breadcrumb">
                    <li class="breadcrumb-item"><a class="text-white" href="Default.aspx">HOME</a></li>
                    <li class="breadcrumb-item text-white active" aria-current="page">FASTAG</li>
                </ol>
            </nav>
        </div>
    </div>
    <!-- Page Header End -->
        <!--fastag-->
    <section class="container-fluid fastag_banner py-5">
        <article class="row">
            <div class="col-lg-6">
             <h1 class="head_text ms-5" runat="server" id="ftagSectionheading"></h1>
             <p class="ms-5" runat="server" id="FtagSection1content"></p>
            <a runat="server" id="FtagSection1btnlink"><button class="ms-5 blue_btn">Learn more</button></a>
            </div>
            <div class="col-lg-6">
                 <asp:Image ID="FtagSection1image" runat="server" style="height:400px;width :100%" />
            </div>
        </article>
    </section>

    <section class="container-fluid what_fastag">
        <article class="row">
            <div class="col-lg-6 ">
                <asp:Image ID="FtagSection2image" runat="server" style="border-radius:0 150px 150px 0; height:500px;width :100%;display:block" />
            </div>
            <div class="col-lg-6 my-4">
                <h2 class="heading" runat="server" id="FtagSection2heading"></h2>
                <p class="" runat="server" id="FtagSection2content"></p>
            </div>
        </article>

    </section>

    <!--what is fastag-->

    <!--how fastag works-->
    <section class="container-fluid how_fastag">
        <article class="row">
            <div class="col-lg-6">
                <h2 class="heading px-5" runat="server" id="FtagSection3Heading"></h2>
                <p class="mt-4 px-5" runat="server" id="FtagSection3content"></p>
            </div>
            <div class="col-lg-6 ">
                  <asp:Image ID="FtagSection3Image" runat="server" class="mb-5" style="height:400px;width :100%" />
            </div>
        </article>

    </section>
</asp:Content>
