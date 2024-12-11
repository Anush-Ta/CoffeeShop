using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoffeeShop.Layouts
{
    public partial class MainMaster : System.Web.UI.MasterPage
    {
        Classes.XCoffeeShopDataContext xt = new Classes.XCoffeeShopDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CustomerId"] != null)
            {
                var CustomerId = Int32.Parse(Session["CustomerId"].ToString());
                Classes.Customer customer = xt.Customers.Where(u => u.Id == CustomerId).FirstOrDefault();
                lblShowName.Text = customer.Person.Name + " " + customer.Person.Family;
            }
            if (Session["AdminId"] != null)
            {
                var AdminId = Int32.Parse(Session["AdminId"].ToString());
                Classes.Admin admin = xt.Admins.Where(u => u.Id == AdminId).FirstOrDefault();
                lblShowName.Text = admin.Person.Name + " " + admin.Person.Family;
            }
            if (Session["PersonelId"] != null)
            {
                var PersonelId = Int32.Parse(Session["PersonelId"].ToString());
                Classes.Personel personel = xt.Personels.Where(u => u.Id ==  PersonelId).FirstOrDefault();
                lblShowName.Text = personel.Person.Name + " " + personel.Person.Family;
            }
        }
    }
}