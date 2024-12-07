using CoffeeShop.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoffeeShop.Customer
{
    public partial class OrderSummary : System.Web.UI.Page
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
                Fillrtl();
            }
        }
        protected void Fillrtl()
        {

            var CustomerId = Int32.Parse(Session["CustomerId"].ToString());
            Classes.Order Order = xt.Orders.Where(u => u.CustomerId == CustomerId).FirstOrDefault();
            List<OrderProduct> ShowOrderProduct = xt.OrderProducts.Where(u => u.OrderId == Order.Id).ToList();
            ltrShowProductSummary.Text = "";
            var SumPrice = 0;
            for (int i = 0; i < ShowOrderProduct.Count; i++)
            {
                ltrShowProductSummary.Text += string.Format(@"
                <tbody>
                       <tr>
                               <td>{0}</td>
                               <td>{1}</td>
                               <td>{2} هزار تومان</td>
                       </tr>
                 </tbody>
                  </div>"  ,
                 ShowOrderProduct[i].Product.Title,
                 ShowOrderProduct[i].Count,
                 ShowOrderProduct[i].Price
                 );
                SumPrice = (ShowOrderProduct[i].Price * ShowOrderProduct[i].Count) + SumPrice;
            }
            ltrShowSum.Text = "";
            ltrShowSum.Text += string.Format(@"
            <tr>
				<th colspan='2' class='text-right font-size-24'>جمع کل</th>
				<th class='font-size-24'>{0} هزار تومان</th>
			</tr>",
            SumPrice
            );
        }
    }
}