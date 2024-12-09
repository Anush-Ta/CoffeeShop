<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/MainMaster.Master" AutoEventWireup="true" CodeBehind="Shops.aspx.cs" Inherits="CoffeeShop.Admin.Shops" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content">
        <asp:Label ID="ltrMassgae" runat="server" Text=""></asp:Label>
        <div class="row">
            <div class="col-4">
                <asp:Label ID="LblShow" runat="server" Text=""></asp:Label><br />
                <label>نام :</label>
                <asp:TextBox class="form-control my-colorpicker1 colorpicker-element" type="text" ID="txtName" runat="server"></asp:TextBox><br />
                <label>آدرس :</label>
                <asp:TextBox class="form-control my-colorpicker1 colorpicker-element" type="text" ID="txtAddress" runat="server"></asp:TextBox><br />
                <label>شماره تلفن1 :</label>
                <asp:TextBox class="form-control my-colorpicker1 colorpicker-element" type="text" ID="txtPhone1" runat="server"></asp:TextBox><br />
                <label>شماره تلفن2 :</label>
                <asp:TextBox class="form-control my-colorpicker1 colorpicker-element" type="text" ID="txtPhone2" runat="server"></asp:TextBox><br />
                <label>موبایل :</label>
                <asp:TextBox class="form-control my-colorpicker1 colorpicker-element" type="text" ID="txtMobile" runat="server"></asp:TextBox><br />
                <div class="form-group">
                    <label for="img1" class="col-sm-4 control-label">انتخاب عکس</label>
                    <div class=" col-sm-8">
                        <asp:FileUpload ID="filePicture" runat="server"  class="form-control" accept=".png,.jpg,.jpeg,.gif" />
                    </div>
                    <div class=" col-sm-3"></div>
                    <div class="form-group col-md-3 ">
                        <asp:Image ID="bodyFilePicture" Width="100%" runat="server" BorderStyle="Solid" />
                    </div>
                </div>
                <label>درباره :</label>
                <asp:TextBox class="form-control my-colorpicker1 colorpicker-element" type="text" ID="txtAbout" runat="server"></asp:TextBox><br />
                <asp:TextBox ID="txtId" runat="server" hidden></asp:TextBox><br />
                <asp:Button class="btn btn-cyan mb-5" type="submit" ID="BtnInsert" OnClick="BtnInsert_Click" runat="server" Text="افزودن" />
                <asp:Button class="btn btn-warning mb-5" type="submit" ID="BtnUpdate" OnClick="BtnUpdate_Click" runat="server" Text="تغییر" />
                <asp:Button class="btn btn-pink mb-5" type="submit" ID="BtnDelete" OnClick="BtnDelete_Click" runat="server" Text="حذف" />
            </div>
            <div class="col-8">
                <table class="table table-striped table-advance table-hover">
                    <thead>
                        <tr class="b-1">
                            <th>ردیف</th>
                            <th>نام</th>
                            <th>آدرس</th>
                            <th>شماره تلفن1</th>
                            <th>شماره تلفن2</th>
                            <th>موبایل</th>
                            <th>درباره</th>
                            <th>عکس</th>
                            <th>عملیات</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Literal ID="LtrShow" runat="server"></asp:Literal>
                    </tbody>
                </table>
            </div>
        </div>
    </section>
</asp:Content>
