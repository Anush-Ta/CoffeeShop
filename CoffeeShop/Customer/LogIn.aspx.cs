using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoffeeShop.Customer
{
    public partial class LogIn : System.Web.UI.Page
    {
        Classes.XCoffeeShopDataContext xt = new Classes.XCoffeeShopDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["Exit"] != null)
            {
                Session.Remove("CustomerId");
            }
        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != String.Empty && txtPassword.Text != String.Empty)
            {
                Classes.Customer LoginCustomer = xt.Customers.Where(u => u.UserName == txtUserName.Text || u.Password == txtPassword.Text).FirstOrDefault();
                if (LoginCustomer != null)
                {
                    Session.Add("CustomerId", LoginCustomer.Id);
                    Response.Redirect("Dashboard.aspx");
                }
                else
                {
                    ltrMassgae.Text = Classes.AlarmSetting.Alertdynamic(" نام کاربری یا رمز عبور اشتباه میباشد!", "خطا", "danger");
                }
            }
            else
            {
                ltrMassgae.Text = Classes.AlarmSetting.Alertdynamic(" تمامی فیلد ها را پر کنید!", "خطا", "danger");
            }
        }
    }
}