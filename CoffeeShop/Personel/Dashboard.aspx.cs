using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoffeeShop.Personel
{
    public partial class Dashboard : System.Web.UI.Page
    {
        Classes.XCoffeeShopDataContext xt = new Classes.XCoffeeShopDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PersonelId"] == null)
            {
                Response.Redirect("LogIn.aspx");
            }
        }
    }
}