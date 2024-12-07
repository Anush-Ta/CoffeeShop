using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoffeeShop.Customer
{
    public partial class SignUp : System.Web.UI.Page
    {
        Classes.XCoffeeShopDataContext xt = new Classes.XCoffeeShopDataContext();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (basic_checkbox_1.Checked == true)
            {
                if (txtName.Text.Length > 0 && txtFamily.Text.Length > 0 && txtNationalCode.Text.Length > 0 && txtMobile.Text.Length > 0
                    && txtUserName.Text.Length > 0 && txtPassWord.Text.Length > 0)
                {
                    Classes.Person VerifyPerson = xt.Persons.Where(u => u.NationalCode == txtNationalCode.Text || u.Mobile == txtMobile.Text).FirstOrDefault();
                    if (VerifyPerson == null)
                    {
                        Classes.Person SubmitPerson = new Classes.Person();
                        SubmitPerson.Name = txtName.Text;
                        SubmitPerson.Family = txtFamily.Text;
                        SubmitPerson.Mobile = txtMobile.Text;
                        SubmitPerson.NationalCode = txtNationalCode.Text;
                        xt.Persons.InsertOnSubmit(SubmitPerson);
                        xt.SubmitChanges();
                        var PrsId = SubmitPerson.Id;

                        Classes.Customer VerifyCustomer = xt.Customers.Where(u => u.UserName == txtUserName.Text).FirstOrDefault();
                        if (VerifyCustomer == null)
                        {
                            Classes.Customer SubmitCustomer = new Classes.Customer();
                            SubmitCustomer.PersonId = PrsId;
                            SubmitCustomer.UserName = txtUserName.Text;
                            SubmitCustomer.Password = txtPassWord.Text;
                            xt.Customers.InsertOnSubmit(SubmitCustomer);
                            xt.SubmitChanges();
                            Response.Redirect("LogIn.aspx");
                        }
                        else
                        {
                            ltrMassgae.Text = Classes.AlarmSetting.Alertdynamic(" نام کاربری تکراری میباشد!", "خطا", "danger");
                        }
                    }
                    else
                    {
                        ltrMassgae.Text = Classes.AlarmSetting.Alertdynamic(" کاربر تکراری می باشد لطفا وارد شوید!", "خطا", "danger");
                    }
                    
                }
                else
                {
                    ltrMassgae.Text = Classes.AlarmSetting.Alertdynamic(" تمامی فیلد ها را پر کنید!", "خطا", "danger");
                }
            }
            else
            {
                ltrMassgae.Text = Classes.AlarmSetting.Alertdynamic(" قوانین را قبول کنید!", "خطا", "danger");
            }
        }
    }
}