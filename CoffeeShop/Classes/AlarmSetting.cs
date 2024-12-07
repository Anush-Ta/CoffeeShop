using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShop.Classes
{
    public static class AlarmSetting
    {
        public static String AlternativeEmployee = "<div class='alert alert-warning alert-dismissible' role='alert'><a type = 'button' class='close' data-dismiss='alert' aria-label='Close' style='color:#000000 !important'><span aria-hidden='true'>&times;</span></a><strong>خطا!</strong> کاربر انتخابی ،جانشین فعال دارد.</div>";
        //alert with close
        public static string Alert_Success_Save_close = "<div class='alert alert-success alert-dismissible' role='alert'><button type ='button' class='close' data-dismiss='alert' aria-label='Close' style='color:#000000 !important'><span aria-hidden='true'>&times;</span></button><strong>موفق آمیز!</strong> ثبت با موفقیت انجام شد.</div>";
        //public static string Alert_Danger_Save_close = "<div class='alert alert-Danger alert-dismissible' role='alert'><button type ='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>&times;</span></button><strong>موفق آمیز!</strong> ثبت با موفقیت انجام شد.</div>";
        public static string Alert_warning_Save_close = "<div class='alert alert-warning alert-dismissible' role='alert'><button type ='button' class='close' data-dismiss='alert' aria-label='Close' style='color:#000000 !important'><span aria-hidden='true'>&times;</span></button><strong>موفق آمیز!</strong> ثبت با موفقیت انجام شد.</div>";
        public static string Alert_Info_Save_close = "<div class='alert alert-info alert-dismissible' role='alert'><button type ='button' class='close' data-dismiss='alert' aria-label='Close' style='color:#000000 !important'><span aria-hidden='true'>&times;</span></button><strong>موفق آمیز!</strong> ثبت با موفقیت انجام شد.</div>";

        public static string Alert_Success_Update_close = "<div class='alert alert-success alert-dismissible' role='alert'><button type ='button' class='close' data-dismiss='alert' aria-label='Close' style='color:#000000 !important'><span aria-hidden='true'>&times;</span></button><strong>موفق آمیز!</strong> بروزرسانی با موفقیت انجام شد.</div>";
        public static string Alert_Danger_Update_close = "<div class='alert alert-Danger alert-dismissible' role='alert'><button type ='button' class='close' data-dismiss='alert' aria-label='Close' style='color:#000000 !important'><span aria-hidden='true'>&times;</span></button><strong>خطا!</strong> بروزرسانی با مشکل رو به رو شد.</div>";
        public static string Alert_warning_Update_close = "<div class='alert alert-warning alert-dismissible' role='alert'><button type ='button' class='close' data-dismiss='alert' aria-label='Close' style='color:#000000 !important'><span aria-hidden='true'>&times;</span></button><strong>موفق آمیز!</strong> بروزرسانی با موفقیت انجام شد.</div>";
        public static string Alert_Info_Update_close = "<div class='alert alert-info alert-dismissible' role='alert'><button type ='button' class='close' data-dismiss='alert' aria-label='Close' style='color:#000000 !important'><span aria-hidden='true'>&times;</span></button><strong>موفق آمیز!</strong> بروزرسانی با موفقیت انجام شد.</div>";

        public static string Alert_Success_Delete_close = "<div class='alert alert-success alert-dismissible' role='alert'><button type ='button' class='close' data-dismiss='alert' aria-label='Close' style='color:#000000 !important'><span aria-hidden='true'>&times;</span></button><strong>خطا!</strong> حذف با موفقیت انجام شد</div>";
        public static string Alert_Danger_Delete_close = "<div class='alert alert-danger alert-dismissible' role='alert'><button type ='button' class='close' data-dismiss='alert' aria-label='Close' style='color:#000000 !important'><span aria-hidden='true'>&times;</span></button><strong>خطا!</strong> حذف با مشکل رو به رو شد</div>";
        public static string Alert_warning_Delete_close = "<div class='alert alert-warning alert-dismissible' role='alert'><button type ='button' class='close' data-dismiss='alert' aria-label='Close' style='color:#000000 !important'><span aria-hidden='true'>&times;</span></button><strong>خطا!</strong> حذف با مشکل رو به رو شد</div>";
        public static string Alert_info_Delete_close = "<div class='alert alert-info alert-dismissible' role='alert'><button type ='button' class='close' data-dismiss='alert' aria-label='Close' style='color:#000000 !important'><span aria-hidden='true'>&times;</span></button><strong>خطا!</strong> حذف با مشکل رو به رو شد</div>";

        public static string Alert_Success_dataerror_close = "<div class='alert alert-success alert-dismissible' role='alert'><button type ='button' class='close' data-dismiss='alert' aria-label='Close' style='color:#000000 !important'><span aria-hidden='true'>&times;</span></button><strong>خطا!</strong> داده در صفحه دیگرمورد استفاده شده</div>";
        public static string Alert_Danger_dataerror_close = "<div class='alert alert-danger alert-dismissible' role='alert'><button type ='button' class='close' data-dismiss='alert' aria-label='Close' style='color:#000000 !important'><span aria-hidden='true'>&times;</span></button><strong>خطا!</strong> داده در صفحه دیگرمورد استفاده شده</div>";
        public static string Alert_warning_dataerror_close = "<div class='alert alert-warning alert-dismissible' role='alert'><button type ='button' class='close' data-dismiss='alert' aria-label='Close' style='color:#000000 !important'><span aria-hidden='true'>&times;</span></button><strong>خطا!</strong> داده در صفحه دیگرمورد استفاده شده</div>";
        public static string Alert_info_dataerror_close = "<div class='alert alert-info alert-dismissible' role='alert'><button type ='button' class='close' data-dismiss='alert' aria-label='Close' style='color:#000000 !important'><span aria-hidden='true'>&times;</span></button><strong>خطا!</strong> داده در صفحه دیگرمورد استفاده شده</div>";

        public static string AlertdynamicClose(string Massege, string MassegeStrong, string cname)
        {
            string Alertdynamics = "<div class='alert alert-" + cname + " alert-dismissible' role='alert'><button type ='button' class='close' data-dismiss='alert' aria-label='Close' style='color:#000000 !important'><span aria-hidden='true'>&times;</span></button><strong>" + MassegeStrong + "! </strong> " + Massege + "</div>";
            return Alertdynamics;
        }
        public static string Alertdynamic(string Massege, string MassegeStrong, string cname)
        {
            string Alertdynamics = "<div class='alert alert-" + cname + "' role='alert'><strong>" + MassegeStrong + "! </strong> " + Massege + "</div>";
            return Alertdynamics;
        }
        public static string Alert_Danger_Save_close = "<div class='alert alert-danger alert-dismissible' role='alert'><button type ='button' class='close' data-dismiss='alert' aria-label='Close' style='color:#000000 !important'><span aria-hidden='true'>&times;</span></button><strong>خطا!</strong> ثبت با مشکل رو به رو شد</div>";
        public static string AlertdynamicLink(string Massege, string MassegeStrong, string cname, string Link = "javascript:window.location.href=window.location.href")
        {
            string Alertdynamics = "<div class='alert alert-" + cname + " alert-dismissible' role='alert'><a href='" + Link + "' type='button' class='close' data-dismiss='alert' aria-label='Close' style='color:#000000 !important'><span aria-hidden='true'>&times;</span></a><strong>" + MassegeStrong + "! </strong> " + Massege + "</div>";
            return Alertdynamics;
        }
    }
}