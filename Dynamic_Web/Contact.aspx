<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Dynamic_Web.Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Page Header Start -->
    <div class="container-fluid page-header py-5 mb-5">
        <div class="container py-5">
            <h1 class="display-3 text-white mb-3 animated slideInDown">CONTACT</h1>
            <nav aria-label="breadcrumb animated slideInDown">
                <ol class="breadcrumb">
                    <li class="breadcrumb-item"><a class="text-white" href="Default.aspx">HOME</a></li>
                    <li class="breadcrumb-item text-white active" aria-current="page">CONTACT</li>
                </ol>
            </nav>
        </div>
    </div>
    <!-- Page Header End -->


    <!-- Contact Start -->
    <div class="container-xxl py-0">
        <div class="container">
            <div class="text-center mx-auto mb-5 wow fadeInUp" data-wow-delay="0.1s" style="max-width: 600px;">
                <br />
                <h1 class="mb-3" style="color: #11799C;" id="section1heading" runat="server"></h1>
                <hr />
                <p runat="server" id="section1content"></p>
            </div>
            <div class="row g-4">
                <div class="col-12">
                    <div class="row gy-4">
                        <div class="col-md-6 col-lg-4 wow fadeIn" data-wow-delay="0.1s">
                            <div class="bg-light rounded p-3">
                                <div class="d-flex align-items-center bg-white rounded p-3" style="border: 1px dashed rgba(0, 185, 142, .3)">
                                    <div class="icon me-4" style="width: 45px; height: 45px; line-height:45px">
                                        <i class="fa fa-map-marker-alt text-primary"></i>
                                    </div>
                                    <span runat="server" id="addressno"></span>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-6 col-lg-4 wow fadeIn" data-wow-delay="0.3s">
                            <div class="bg-light rounded p-3">
                                <div class="d-flex align-items-center bg-white rounded p-3" style="border: 1px dashed rgba(0, 185, 142, .3)">
                                    <div class="icon me-3" style="width: 45px; height: 45px; line-height:45px">
                                        <i class="fa fa-envelope-open text-primary"></i>
                                    </div>
                                    <span runat="server" id="emailid"></span>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-6 col-lg-4 wow fadeIn" data-wow-delay="0.5s">
                            <div class="bg-light rounded p-3">
                                <div class="d-flex align-items-center bg-white rounded p-3" style="border: 1px dashed rgba(0, 185, 142, .3)">
                                    <div class="icon me-3" style="width: 45px; height: 45px; line-height:45px">
                                        <i class="fa fa-phone-alt text-primary"></i>
                                    </div>
                                    <span runat="server" id="contectno"></span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-12">
                    <div class="row gy-4">
                        <div class="col-md-6 col-lg-6 wow fadeIn" data-wow-delay="0.1s">
                            <asp:Image ID="section1image" runat="server" class="img-fluid" Style="background-size: cover; margin-top: 25px; border-radius: 15px; height: 400px; width: 100%; display: block" alt="" />
                        </div>
                        <div class="col-md-6 col-lg-6 wow fadeIn" data-wow-delay="0.5s">
                            <p class="mb-4"></p>
                            <form>
                                <div class="row g-3">
                                    <div class="col-md-6">
                                        <div class="form-floating">
                                            <input type="Text" class="form-control" runat="server" id="exampleFormControlInput1" placeholder="Enter Your Name">
                                            <label for="name">Your Name</label>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-floating">
                                            <input type="email" class="form-control" runat="server" id="exampleFormControlInput2" placeholder="Enter Your Email">
                                            <label for="email">Your Email</label>
                                        </div>
                                    </div>
                                    <div class="col-12">
                                        <div class="form-floating">
                                            <textarea class="form-control" placeholder="Leave a message here" runat="server" id="exampleFormControlTextarea1" style="height: 250px"></textarea>
                                            <label for="message">Message</label>
                                        </div>
                                    </div>
                                    <div class="col-12">
                                        <asp:Button runat="server" ID="btnSendMessage" class="btn w-100 py-3" Style="background-color: #11799C; color: white" Text="Send Message" OnClick="btnSendMessage_Click" />
                                        <asp:Label ID="MessageShow" runat="server"></asp:Label>
                                    </div>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Contact End -->
</asp:Content>
