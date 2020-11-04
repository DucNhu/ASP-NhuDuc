<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WingtipToys._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="mb-70vh position-relative">
        <div id="carouselExampleControls" class="carousel slide position-fixed w-100 h-100" data-ride="carousel" style="top: -5em;">


            <div class="carousel-inner h-100">
                <div class="carousel-item active h-100">
                    <div class="box-classList">
                        <h1 class="title-web">Wintip Toys</h1>
                        <a runat="server" href="~/ProductList" class="link-pList">ProducList</a>
                    </div>
                    <img src="https://wingtipbrewing.com/wp-content/uploads/2019/08/wingtip-home-slider.jpg" class="d-block w-100 h-100" alt="...">
                </div>
                <div class="carousel-item h-100">
                    <img src="https://wingtipbrewing.com/wp-content/uploads/2019/08/DSC_4865.jpg" class="d-block w-100 h-100" alt="...">
                </div>
                <div class="carousel-item h-100">
                    <img src="https://wingtipbrewing.com/wp-content/uploads/2019/09/wingtip-home-slider-3.jpg" class="d-block w-100 h-100" alt="...">
                </div>
            </div>
            <a class="carousel-control-prev" href="#carouselExampleControls" role="button" data-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="carousel-control-next" href="#carouselExampleControls" role="button" data-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
            </a>
        </div>
    </div>
</asp:Content>
