<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/MainMaster.Master" AutoEventWireup="true" CodeBehind="Shops.aspx.cs" Inherits="CoffeeShop.Customer.Shops" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content">
        <div class="row">
            <asp:Literal ID="ltrShowShops" runat="server"></asp:Literal>
        </div>
    </section>
</asp:Content>
