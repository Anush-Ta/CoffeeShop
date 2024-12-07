using CoffeeShop.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoffeeShop.Customer
{
    public partial class Shops : System.Web.UI.Page
    {
        Classes.XCoffeeShopDataContext xt = new Classes.XCoffeeShopDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CustomerId"] == null)
            {
                Response.Redirect("LogIn.aspx");
            }
            else
            {
                FillLtr();
            }
            
        }
        protected void FillLtr()
        {
            List<Shop> shop = xt.Shops.OrderBy(u => u.Name).ToList();
            ltrShowShops.Text = "";
            for (int i = 0; i < shop.Count; i++)
            {
                ltrShowShops.Text += string.Format(@"
                    <div class='col-12 col-lg-6 col-xl-4'>
                         <div class='box'>
                            <div class='box-body'>
                                 <div class='product-img'>
                                     <img src='../../images/product/product-1.png' alt=''>
                                </div>
                            <div class='product-text'>
                                  <div class='pro-img-overlay'>
                                        <a href='OrderRegistration.aspx?ShopId={0}' class='btn btn-rounded btn-dark mb-5'><i>مشاهده</i></a>
                                  </div>
                                        <h3 class='box-title mb-0'>{1}</h3>
                                        <h5 class='box-title mb-0'>آدرس : {2}</h5>
                                        <small class='text-muted db'></small>
                            </div>
                         </div>
                    </div>
                </div>",
                 shop[i].Id,
                 shop[i].Name,
                 shop[i].Address
                    );
            }
        }
    }
}