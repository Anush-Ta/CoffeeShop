<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/MainMaster.Master" AutoEventWireup="true" CodeBehind="ProductRegistration.aspx.cs" Inherits="CoffeeShop.Customer.ProductRegistration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content">
        <asp:Label ID="ltrMassgae" runat="server" Text=""></asp:Label>
        <asp:Literal ID="ltrProductDetail" runat="server"></asp:Literal>
        <asp:TextBox ID="txtShopProductId" runat="server" hidden></asp:TextBox>
        <asp:Button class="btn btn-rounded btn-secondary mb-5" ID="btnAdd" OnClick="btnAdd_Click" runat="server" Text="افزودن به سبد خرید" />
    </section>
</asp:Content>
