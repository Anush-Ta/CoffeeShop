<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/MainMaster.Master" AutoEventWireup="true" CodeBehind="OrderSummary.aspx.cs" Inherits="CoffeeShop.Customer.OrderSummary" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content">

        <div class="row">
            <div class="col-12">
                <div class="box">
                    <div class="box-header">
                        <h4 class="box-title">خلاصه سفارش</h4>
                    </div>
                    <div class="box-body">
                        <div class="table-responsive">
                            <table class="table table-bordered">
                                <thead>
                                    <tr>
                                        <th>نام کالا</th>
                                        <th>تعداد</th>
                                        <th class="w-200">قیمت</th>
                                    </tr>
                                </thead>
                                <asp:Literal ID="ltrShowProductSummary" runat="server"></asp:Literal>
                                <asp:Literal ID="ltrShowSum" runat="server"></asp:Literal>
                            </table>
                        
                </div>
            </div>

        </div>

    </section>
</asp:Content>
