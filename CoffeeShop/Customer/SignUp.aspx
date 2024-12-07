<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="CoffeeShop.Customer.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">
    <link rel="icon" href="../../images/favicon.ico">

    <title>SignUp</title>

    <!-- Bootstrap 4.0-->
    <link rel="stylesheet" href="../../assets/vendor_components/bootstrap/dist/css/bootstrap.min.css">

    <!-- Bootstrap extend-->
    <link rel="stylesheet" href="../css/bootstrap-extend.css">

    <!-- Theme style -->
    <link rel="stylesheet" href="../css/master_style.css">

    <!-- Superieur Admin skins -->
    <link rel="stylesheet" href="../css/skins/_all-skins.css">

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
	<script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
	<script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
	<![endif]-->

</head>
<body class="hold-transition bg-img rtl" style="background-image: url(../../images/gallery/full/6.jpg)" data-overlay="4">
    <asp:Label ID="ltrMassgae" runat="server" Text="Label"></asp:Label>
    <form id="form1" runat="server">
        <div class="auth-2-outer row align-items-center h-p100 m-0">
            <div class="auth-2">
                <div class="auth-logo font-size-40">
                    <a href="../index.html" class="text-white"><b>کافی شاپ</b></a>
                </div>
                <!-- /.login-logo -->
                <div class="auth-body">
                    <p class="auth-msg">ثبت عضو جدید</p>
                    <div class="form-group has-feedback">
                        <asp:TextBox ID="txtName" class="form-control" placeholder="نام" MaxLength="50" runat="server"></asp:TextBox>
                        <span class="ion ion-person form-control-feedback "></span>
                    </div>
                    <div class="form-group has-feedback">
                        <asp:TextBox ID="txtFamily" class="form-control" placeholder="نام خانوادگی" MaxLength="50" runat="server"></asp:TextBox>
                        <span class="ion ion-person form-control-feedback "></span>
                    </div>
                    <div class="form-group has-feedback">
                        <asp:TextBox ID="txtNationalCode" class="form-control JustNum" placeholder="کدملی" MaxLength="50" runat="server"></asp:TextBox>
                        <span class="ion ion-person form-control-feedback "></span>
                    </div>
                    <div class="form-group has-feedback">
                        <asp:TextBox ID="txtMobile" class="form-control JustNum" placeholder="شماره همراه" MaxLength="20" runat="server"></asp:TextBox>
                        <span class="ion ion-person form-control-feedback "></span>
                    </div>
                    <div class="form-group has-feedback">
                        <asp:TextBox ID="txtUserName" class="form-control" placeholder="نام کاربری" MaxLength="50" runat="server"></asp:TextBox>
                        <span class="ion ion-person form-control-feedback "></span>
                    </div>
                    <div class="form-group has-feedback">
                        <asp:TextBox ID="txtPassWord" class="form-control" placeholder="رمز عبور" type="password" MaxLength="50" runat="server"></asp:TextBox>
                        <span class="ion ion-locked form-control-feedback "></span>
                    </div>
                    <div class="row">
                        <div class="col-12">
                            <div class="checkbox">
                                <input type="checkbox" id="basic_checkbox_1" runat="server">
                                <label for="basic_checkbox_1"><b><a href="#" class="text-danger">قوانین </a></b> را قبول دارم</label>
                            </div>
                        </div>
                        <!-- /.col -->
                        <div class="col-12 text-center">
                            <asp:Button ID="btnSubmit" class="btn btn-block mt-10 btn-success" OnClick="btnSubmit_Click" runat="server" Text="ثبت نام" />
                        </div>
                        <!-- /.col -->
                    </div>

                    <div class="text-center text-white">
                        <p class="mt-50">- ورود با -</p>
                        <p class="gap-items-2 mb-20">
                            <a class="btn btn-social-icon btn-outline btn-white" href="#"><i class="fa fa-facebook"></i></a>
                            <a class="btn btn-social-icon btn-outline btn-white" href="#"><i class="fa fa-twitter"></i></a>
                            <a class="btn btn-social-icon btn-outline btn-white" href="#"><i class="fa fa-google-plus"></i></a>
                            <a class="btn btn-social-icon btn-outline btn-white" href="#"><i class="fa fa-instagram"></i></a>
                        </p>
                    </div>
                    <!-- /.social-auth-links -->

                    <div class="margin-top-30 text-center">
                        <p>از قبل حساب کاربری دارید؟ <a href="LogIn.aspx" class="text-info m-l-5">ورود</a></p>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <!-- jQuery 3 -->
    <script src="../../assets/vendor_components/jquery-3.3.1/jquery-3.3.1.js"></script>

    <!-- popper -->
    <script src="../../assets/vendor_components/popper/dist/popper.min.js"></script>

    <!-- Bootstrap 4.0-->
    <script src="../../assets/vendor_components/bootstrap/dist/js/bootstrap.min.js"></script>

    
</body>
</html>
