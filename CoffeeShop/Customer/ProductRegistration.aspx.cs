using CoffeeShop.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoffeeShop.Customer
{
    public partial class ProductRegistration : System.Web.UI.Page
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
                txtShopProductId.Text = Request["ShopProductId"];
            }
        }
        protected void FillLtr()
        {
            ltrProductDetail.Text = "";
            Classes.ShopProduct ShopProductDetails = xt.ShopProducts.Where(u => u.Id == Int32.Parse(Request["ShopProductId"])).FirstOrDefault();
            ltrProductDetail.Text += string.Format(@"
            <div class='row'>
                <div class='col-lg-12'>
                    <div class='box'>
                        <div class='box-body'>
                            <div class='row'>
                                <div class='col-md-4 col-sm-6'>
                                    <div class='box box-body b-1 text-center no-shadow'>
                                        <img src='../../images/product/product-6.png' id='product-image' class='img-fluid' alt=''>
                                    </div>
                                    
                                    </div>
                                    <div class='clear'></div>
                                <div class='col-md-8 col-sm-6'>
                                    <h1 class='box-title mt-0'>{0}</h1>
                                    <h3 class='pro-price mb-0 mt-20'>{1} هزار تومان</h3>
                                    <hr>
                                    <p>{2}</p>
                                    <div class='row'>
                                        <div class='col-sm-12'>
                                            <div class='input-group'>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div> ",
            ShopProductDetails.Product.Title,
            ShopProductDetails.Price,
            ShopProductDetails.Details
            );
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var CustomerId = Int32.Parse(Session["CustomerId"].ToString());
            Classes.Order CheckOrder = xt.Orders.Where(u => u.CustomerId == CustomerId && u.IsDone == null).FirstOrDefault();
            if (CheckOrder == null)
            {
                DateTime now = DateTime.Now;
                Classes.ShopProduct shopProduct = xt.ShopProducts.Where(u => u.Id == Int32.Parse(txtShopProductId.Text)).FirstOrDefault();
                Classes.Order InsertOrder = new Classes.Order();
                InsertOrder.CustomerId = CustomerId;
                InsertOrder.ShopId = shopProduct.ShopId;
                InsertOrder.Date = now;
                InsertOrder.OrderCode = 100;
                xt.Orders.InsertOnSubmit(InsertOrder);
                xt.SubmitChanges();

                Classes.OrderProduct InsertOrderProduct = new Classes.OrderProduct();
                InsertOrderProduct.Price = shopProduct.Price;
                InsertOrderProduct.Count = 1;
                InsertOrderProduct.ProductId = shopProduct.ProductId;
                InsertOrderProduct.OrderId = InsertOrder.Id;
                xt.OrderProducts.InsertOnSubmit(InsertOrderProduct);
                xt.SubmitChanges();
                ltrMassgae.Text = Classes.AlarmSetting.Alertdynamic("کالا با موفقیت به سبد خرید اضافه شد","", "success");
            }
            else
            {
                var x = Int32.Parse(txtShopProductId.Text);
                Classes.ShopProduct shopProduct = xt.ShopProducts.Where(u => u.Id == Int32.Parse(txtShopProductId.Text)).FirstOrDefault();
                if (shopProduct.ShopId == CheckOrder.ShopId)
                {
                    Classes.OrderProduct UpdateOrderProduct = xt.OrderProducts.Where(u => u.OrderId == CheckOrder.Id && u.ProductId == shopProduct.ProductId).SingleOrDefault();

                    if (UpdateOrderProduct != null)
                    {
                        UpdateOrderProduct.Count = UpdateOrderProduct.Count + 1;
                        xt.SubmitChanges();
                        ltrMassgae.Text = Classes.AlarmSetting.Alertdynamic("کالا با موفقیت به سبد خرید اضافه شد", "", "success");
                    }
                    else
                    {
                        Classes.Order Order = xt.Orders.Where(u => u.CustomerId == CustomerId).FirstOrDefault();
                        Classes.OrderProduct InsertOrderProduct = new Classes.OrderProduct();
                        InsertOrderProduct.Price = shopProduct.Price;
                        InsertOrderProduct.Count = 1;
                        InsertOrderProduct.ProductId = shopProduct.ProductId;
                        InsertOrderProduct.OrderId = Order.Id;
                        xt.OrderProducts.InsertOnSubmit(InsertOrderProduct);
                        xt.SubmitChanges();
                        ltrMassgae.Text = Classes.AlarmSetting.Alertdynamic("کالا با موفقیت به سبد خرید اضافه شد", "", "success");
                    }
                }
                else
                {
                    ltrMassgae.Text = Classes.AlarmSetting.Alertdynamic("کالا با موفقیت به سبد خرید اضافه شد", "", "success");
                }
            }
        }
    }
}