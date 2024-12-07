using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace CoffeeShop.Admin
{
    public partial class Shops : System.Web.UI.Page
    {
        Classes.XCoffeeShopDataContext xt = new Classes.XCoffeeShopDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["act"] != null && Request["act"] == "Show" && Request["ShopId"] != null)
                {
                    int ShopId = Int32.Parse(Request["ShopId"]);
                    Classes.Shop Shop = xt.Shops.Where(u => u.Id == ShopId).SingleOrDefault();

                    txtId.Text = Shop.Id.ToString();
                    txtName.Text = Shop.Name;
                    txtAddress.Text = Shop.Address;
                    txtPhone1.Text = Shop.Phone1;
                    txtPhone2.Text = Shop.Phone2;
                    txtMobile.Text = Shop.Mobile;
                    txtAbout.Text = Shop.About;
                }
                FillGrid();
            }
        }

        private void FillGrid()
        {
            Classes.Shop[] ShowShop = xt.Shops.ToArray();

            LtrShow.Text = "";
            for (int i = 0; i < ShowShop.Length; i++)
            {
                var ImageUrl = "";
                if (ShowShop[i].Image != null)
                {
                    byte[] data = ShowShop[i].Image.ToArray();
                    var base64 = System.Convert.ToBase64String(data, 0, ShowShop[i].Image.Length);
                    ImageUrl = "data:image/png;base64," + base64;

                }


                LtrShow.Text += string.Format(@"<tr class=''b-1''>
                <td>{0}</td>
                <td>{1}</td>
                <td>{2}</td>
                <td>{3}</td>
                <td>{4}</td>
                <td>{5}</td>
                <td>{6}</td>
                <td><image src='{7}'></td>
                <td><a href='Person.aspx?act=Show&ShopId={8}' class='btn btn-success btn-xs'>نمایش</a></td>",
                (i + 1).ToString(),
                ShowShop[i].Name,
                ShowShop[i].Address,
                ShowShop[i].Phone1,
                ShowShop[i].Phone2,
                ShowShop[i].Mobile,
                ImageUrl,
                ShowShop[i].About,
                ShowShop[i].Id);
            }

        }

        protected void BtnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) && string.IsNullOrEmpty(txtAddress.Text) && string.IsNullOrEmpty(txtPhone1.Text)
                && string.IsNullOrEmpty(txtPhone1.Text) && string.IsNullOrEmpty(txtAbout.Text))
            {
                bool CheckShop = false;
                Classes.Shop[] VerifyShop = xt.Shops.Where(u => u.Name == txtName.Text || u.Phone1 == txtPhone1.Text
                || u.Phone2 == txtPhone2.Text || u.Mobile == txtMobile.Text).ToArray();

                if (VerifyShop.Length > 0)
                    CheckShop = true;
                if (CheckShop == false)
                {
                    Classes.Shop InsertShop = new Classes.Shop();
                    InsertShop.Name = txtName.Text;
                    InsertShop.Address = txtAddress.Text;
                    InsertShop.Phone1 = txtPhone1.Text;
                    InsertShop.Phone2 = txtPhone2.Text;
                    InsertShop.Mobile = txtMobile.Text;
                    InsertShop.About = txtAbout.Text;
                    FileUpload img1 = (FileUpload)filePicture;
                    Byte[] imgByte1 = null;
                    if (img1.HasFile && img1.PostedFile != null)
                    {
                        HttpPostedFile File = filePicture.PostedFile;
                        imgByte1 = new Byte[File.ContentLength];
                        File.InputStream.Read(imgByte1, 0, File.ContentLength);
                        InsertShop.Image = imgByte1;
                    }
                    xt.Shops.InsertOnSubmit(InsertShop);
                    xt.SubmitChanges();
                    Response.Redirect("Shops.aspx");
                }
                else
                {
                    ltrMassgae.Text = Classes.AlarmSetting.Alertdynamic(" داده تکراری می باشد!", "خطا", "danger");
                }
            }
            else
            {
                ltrMassgae.Text = Classes.AlarmSetting.Alertdynamic("لطفا تمامی فیلدها را پر کنید!", "خطا", "danger");
            }
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) && string.IsNullOrEmpty(txtAddress.Text) && string.IsNullOrEmpty(txtPhone1.Text)
                && string.IsNullOrEmpty(txtPhone1.Text) && string.IsNullOrEmpty(txtAbout.Text))
            {
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    Classes.Shop UpdateShop = xt.Shops.Where(u => u.Id == Int32.Parse(txtId.Text)).SingleOrDefault();

                    if (UpdateShop != null)
                    {
                        Classes.Shop[] CheckShopUniqe = xt.Shops.Where(u => u.Id != Int32.Parse(txtId.Text) && 
                        (u.Phone1 == txtPhone1.Text || u.Mobile == txtMobile.Text || u.Phone2 == txtPhone2.Text)).ToArray();

                        if (CheckShopUniqe.Length == 0)
                        {
                            UpdateShop.Name = txtName.Text;
                            UpdateShop.Address = txtAddress.Text;
                            UpdateShop.Phone1 = txtPhone1.Text;
                            UpdateShop.Phone2 = txtPhone2.Text;
                            UpdateShop.Mobile = txtMobile.Text;
                            FileUpload img1 = (FileUpload)filePicture;
                            Byte[] imgByte1 = null;
                            if (img1.HasFile && img1.PostedFile != null)
                            {
                                HttpPostedFile File = filePicture.PostedFile;
                                imgByte1 = new Byte[File.ContentLength];
                                File.InputStream.Read(imgByte1, 0, File.ContentLength);
                                UpdateShop.Image = imgByte1;
                            }
                            UpdateShop.About = txtAbout.Text;
                            xt.SubmitChanges();
                            Response.Redirect("Shops.aspx");
                        }
                        else
                        {
                            ltrMassgae.Text = Classes.AlarmSetting.Alertdynamic(" داده تکراری می باشد!", "خطا", "danger");
                        }

                    }
                }
                else
                {
                    ltrMassgae.Text = Classes.AlarmSetting.Alertdynamic(" داده ای وجود ندارد!", "خطا", "danger");
                }
            }
            else
            {
                ltrMassgae.Text = Classes.AlarmSetting.Alertdynamic("لطفا تمامی فیلدها را پر کنید!", "خطا", "danger");
            }
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Length > 0)
            {
                Classes.Shop DeleteShop = xt.Shops.Where(u => u.Id == Int32.Parse(txtId.Text)).SingleOrDefault();

                if (DeleteShop != null)
                {
                    bool IsUsedInOrder = xt.Orders.Any(u => u.ShopId == Int32.Parse(txtId.Text));
                    bool IsUsedInShopProduct = xt.ShopProducts.Any(u => u.ShopId == Int32.Parse(txtId.Text));
                    bool IsUsedInPersonelShopHistory = xt.PersonelShopHistories.Any(u => u.ShopId == Int32.Parse(txtId.Text));
                    bool IsUsed = IsUsedInOrder || IsUsedInShopProduct || IsUsedInPersonelShopHistory;
                    if (IsUsed == false)
                    {
                        xt.Shops.DeleteOnSubmit(DeleteShop);
                        xt.SubmitChanges();
                        Response.Redirect("Shops.aspx");
                    }
                    else
                    {
                        ltrMassgae.Text = Classes.AlarmSetting.Alertdynamic("این داده حذف نمی شود لطفا داده دیگری انتخاب کنید!", "خطا", "danger");
                    }
                }
            }
            else
            {
                ltrMassgae.Text = Classes.AlarmSetting.Alertdynamic("لطفا تمامی فیلدها را پر کنید!", "خطا", "danger");
            }
        }
    }
}