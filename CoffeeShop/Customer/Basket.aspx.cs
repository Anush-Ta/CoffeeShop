using CoffeeShop.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoffeeShop.Customer
{
    public partial class Basket : System.Web.UI.Page
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
            var CustomerId = Int32.Parse(Session["CustomerId"].ToString());
            Classes.Order Order = xt.Orders.Where(u => u.CustomerId == CustomerId).OrderByDescending(u => u.Id).FirstOrDefault();
            List<OrderProduct> ShowOrderProduct = xt.OrderProducts.Where(u => u.OrderId == Order.Id).ToList();
            ltrShowOrderProduct.Text = "";
            for (int i = 0; i < ShowOrderProduct.Count; i++)
            {
				ltrShowOrderProduct.Text += string.Format(@"
						<tbody>
						<tr role='row' class='odd'>
								<td class='sorting_1'>{0}</td>
                                <td>{1}</td>
								<td>{2}</td>
								<td>{3}</td>
								<td>{4} هزار تومان</td>
                                <td>{5}</td>
								<td><a href='javascript:void(0)' class='btn btn-icon-circle btn-info' data-toggle='tooltip' data-original-title='Edit'>
										<i class='ti-marker-alt'></i>
									</a> 
									<a href='javascript:void(0)' class='btn btn-icon-circle btn-danger' data-original-title='Delete' data-toggle='tooltip'>
										<i class='ti-trash'></i>
									</a>
								</td>
							</tr></tbody>",
					Order.Id,
                    Order.Shop.Name,
					ShowOrderProduct[i].Product.Title,
					ShowOrderProduct[i].Count,
                    ShowOrderProduct[i].Price,
					ShowOrderProduct[i].Order.Date
                    );
            }
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderSummary.aspx");
        }
    }
}