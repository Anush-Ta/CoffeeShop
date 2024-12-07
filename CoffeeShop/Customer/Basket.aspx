<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/MainMaster.Master" AutoEventWireup="true" CodeBehind="Basket.aspx.cs" Inherits="CoffeeShop.Customer.Basket" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content">
        <div class="row">
            <div class="col-12">
                <div class="box">
                    <div class="box-body">
                        <div class="table-responsive">
                            <div id="productorder_wrapper" class="dataTables_wrapper container-fluid dt-bootstrap4 no-footer">
                                <div class="row">
                                    <div class="col-sm-12 col-md-6">
                                        
                                        </div>
                                        <div class="col-sm-12 col-md-6">
                                            <div id="productorder_filter" class="dataTables_filter">
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-12">
                                            <table id="productorder" class="table table-hover no-wrap product-order dataTable no-footer" data-page-size="10" role="grid" aria-describedby="productorder_info">
                                                <thead>
                                                    <tr class="bg-secondary" role="row">
                                                        <th class="sorting_asc" tabindex="0" aria-controls="productorder" rowspan="1" colspan="1" aria-sort="ascending" aria-label="Customer: activate to sort column descending">کد سفارش</th>
                                                        <th class="sorting" tabindex="0" aria-controls="productorder" rowspan="1" colspan="1" aria-label="Order ID: activate to sort column ascending">نام کافه</th>
                                                        <th class="sorting" tabindex="0" aria-controls="productorder" rowspan="1" colspan="1" aria-label="Order ID: activate to sort column ascending">نام کالا</th>
                                                        <th class="sorting" tabindex="0" aria-controls="productorder" rowspan="1" colspan="1" aria-label="Photo: activate to sort column ascending">تعداد</th>
                                                        <th class="sorting" tabindex="0" aria-controls="productorder" rowspan="1" colspan="1" aria-label="Photo: activate to sort column ascending">قیمت کالا</th>
                                                        <th class="sorting" tabindex="0" aria-controls="productorder" rowspan="1" colspan="1" aria-label="Product: activate to sort column ascending">تاریخ</th>
                                                        <th class="sorting" tabindex="0" aria-controls="productorder" rowspan="1" colspan="1" aria-label="Quantity: activate to sort column ascending">عملیات</th>
                                                    </tr>
                                                </thead>
                                                <asp:Literal ID="ltrShowOrderProduct" runat="server"></asp:Literal>
                                            </table>
                                        </div>
                                    </div>
                                    <div class="row">
                                    </div>
                                </div>
                        </div>
                    </div>
                    <asp:Button ID="btnNext" class="btn btn-rounded btn-dark mb-5" OnClick="btnNext_Click" runat="server" Text="ادامه" />
                </div>
            </div>
        </div>

    </section>
</asp:Content>
