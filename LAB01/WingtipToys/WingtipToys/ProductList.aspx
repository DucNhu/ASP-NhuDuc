<%@ Page Title="List Product" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="WingtipToys.ProductList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <div class="container">
            <h2>Home / <%: Page.Title %></h2>
            <div class="container">
                <div class="row">
                    <asp:ListView ID="productList" runat="server"
                        DataKeyNames="ProductID" GroupItemCount="4"
                        ItemType="WingtipToys.Models.Product" SelectMethod="GetProducts" OnSelectedIndexChanged="productList_SelectedIndexChanged">
                        <EmptyDataTemplate>
                            <table>
                                <tr>
                                    <td>No data was returned</td>
                                </tr>
                            </table>
                        </EmptyDataTemplate>

                        <GroupTemplate>
                            <tr id="itemPlaceholderContainer" runat="server">
                                <td id="itemPlaceholder" runat="server"></td>
                            </tr>
                        </GroupTemplate>
                        <ItemTemplate>

                            <div class="col-xl-3 col-md-3 col-sm-6 item_product" runat="server">
                                <div class="frame-img_product">
                                    <a href="ProductDetails.aspx?productID=<%#:Item.ProductID%>">
                                        <img src="/Images/<%#:Item.ImagePath%>" />
                                    </a>
                                </div>
                                <div class="product-des">
                                    <a href="ProductDetails.aspx?productID=<%#:Item.ProductID %>">
                                        <br />
                                        <span><%#:Item.ProductName %></span>
                                    </a>
                                    <br />
                                    <span class="line-2rem">
                                        <b>Price:</b><%#:String.Format("{0:c}", Item.UnitPrice) %> 
                                        <%-- float: right --%>
                                        <span class="float-right add-cart">
                                            <a href="/AddToCart.aspx?productID=<%#: Item.ProductID %>"><i class="fas fa-cart-plus"></i></a>
                                        </span>
                                    </span><br />
                                </div>
                            </div>

                        </ItemTemplate>
                        <%--       <LayoutTemplate>
                    <table style="width: 100%">
                        <tbody>
                            <tr>
                                <td>
                                    <table id="groupPlaceholderContainer" runat="server" style="width: 100%">
                                        <tr id="groupPlaceholder"></tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                            </tr>
                        </tbody>
                    </table>
                </LayoutTemplate>--%>
                    </asp:ListView>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
