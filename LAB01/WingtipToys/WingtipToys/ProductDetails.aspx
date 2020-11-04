<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="WingtipToys.ProductDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="productDetails" runat="server" ItemType="WingtipToys.Models.Product"
        SelectMethod="GetProduct" RenderOuterTable="false">
        <ItemTemplate>
            <div class="row">
                <div class="col-sm-12">
                    <h1 class="ml-5">
                        <%#:Item.ProductName %>
                    </h1>
                </div>
                <div class="container">
                    <!-- Img -->
                    <div class="col-sm-12 col-md-6">
                        <img src="/Images/<%#:Item.ImagePath %>" alt="<%#:Item.Description %>" class="img-fluid" />
                    </div>
                    <!-- Details -->
                    <div class="col-sm-12 col-md-6">
                        <div class="col-sm-12 col-md-12">
                            <span><b>Description:</b></span><%#:Item.Description %>
                        </div>
                        <div class="col-sm-12 col-md-12 my-5">
                            <span><b>Price:</b></span><%#: String.Format("{0:c}", Item.UnitPrice) %>
                        </div>
                        <div class="col-sm-12 col-md-12">
                            <span><b>ID:</b></span><%#:Item.ProductID %>
                        </div>
                    </div>
                    <hr />                </div>
            </div>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
