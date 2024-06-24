using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Web.Services;

public partial class Pages_Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["userName"] == null)
        {
            lbl_Welcome.Text = "צהריים טובים אורח";
            btn_logout.Visible = false;
            btn_UpdateUserInfo.Visible = false;
            btn_uploadProduct.Visible = false;
            btn_MyProducts.Visible = false;
            lbl_UserName.Text = "guest";
            Response.Redirect("./Login.aspx");
        }
        else
        {
            lbl_Welcome.Text = Session["userName"].ToString() + " צהריים טובים " ;
            lbl_UserName.Text = Session["userName"].ToString();
            btn_logout.Visible = true;

        }
    }

    protected void btn_login_goto_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/User/Login.aspx");
    }

    protected void btn_register_goto_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/User/Register.aspx");
    }

    protected void btn_uploadProduct_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/User/UploadProduct.aspx");
    }
    protected void btn_logout_to_Login(object sender, EventArgs e)
    {
        Session["userName"] = null;
        Response.Redirect("~/User/Login.aspx");
    }

    protected void ddl_Category_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    //protected void btn_Filter_Click(object sender, EventArgs e)
    //{
    //    //Response.Write("<div class='Products'>");
    //    BlockFilter();
    //    //Response.Write("</div>");
    //}
    public void BlockFilter(string searchText)
    {
        users us = new users();
        // מכניס נתונים לטבלה
        Products filteProducts = new Products();
        grd_AllProducts.DataSource = filteProducts.SearchProducts(searchText.ToString());
        grd_AllProducts.DataBind();
        string name = "";
        // מעלה את הנתונים מהטבלה לצורה יפה
        //Response.Write("<div class='Products'>");
            Response.Write("<div class='Products'>");
            foreach (GridViewRow row in grd_AllProducts.Rows)
            {
            if (Session["userName"] == null)
            {
                name = us.GetUsernameById(row.Cells[2].Text);
                Response.Write("<div class='blocks'>");
                //Response.Write("    <div class='Blocklbl'>");
                //Response.Write("        <p>" + row.Cells[1].Text + "</p>");
                //Response.Write("    </div>");
                //Response.Write("<div>");
                //Response.Write("    <button onclick='AddToFavorite()' class='InvisableButton'>");
                //Response.Write("        <img id='" + row.Cells[0].Text + "' src='../img/heart-Logo.png' class='ImgBlack CartLogo' />");
                //Response.Write("    </button>");
                //Response.Write("</div>");
                Response.Write("    <div class='image'>");
                Response.Write("        <img class='' alt='product image' src='" + row.Cells[1].Text + "' width='300' height='300'>");
                Response.Write("    </div>");
                //Response.Write("    <div class='description'>");
                //Response.Write("        <p>" + row.Cells[10].Text + "</p>");
                //Response.Write("    </div>");
                //Response.Write("    <div class='Phone_Number'>");
                //Response.Write("        <p>מספר טלפון: " + us.GetPhoneNumberByUserName(name) + "</p>");
                //Response.Write("    </div>");
                //Response.Write("    <div class='Seller_Name'>");
                //Response.Write("        <p>שם המוכר: " + name + "</p>");
                //Response.Write("    </div>");
                //Response.Write("    <div class='Usage_Level'>");
                //Response.Write("        <p>רמת השימוש: " + filteProducts.GetConditionById(row.Cells[8].Text) + "</p>");
                //Response.Write("    </div>");
                //Response.Write("    <div class='Categorys'>");
                //Response.Write("        <p>קטגוריה: " + filteProducts.GetCategoryById(row.Cells[4].Text) + "</p>");
                //Response.Write("    </div>");
                //Response.Write("    <div class='Price'>");
                //Response.Write("        <p>מחיר: " + row.Cells[9].Text + "</p>");
                //Response.Write("    </div>");
                Response.Write("</div>");
            }
            else if (filteProducts.IsFavoriteProductsExists(Session["userName"].ToString(), row.Cells[0].Text))
            {
                name = us.GetUsernameById(row.Cells[2].Text);
                Response.Write("<div class='blocks'>");
                Response.Write("    <div class='Blocklbl'>");
                Response.Write("        <p>" + row.Cells[1].Text + "</p>");
                Response.Write("    </div>");
                Response.Write("<div>");
                Response.Write("    <button onclick='AddToFavorite()' class='InvisableButton'>");
                Response.Write("        <img id='" + row.Cells[0].Text + "' src='../img/heart-Logo.png' class='CartLogo' />");
                Response.Write("    </button>");
                Response.Write("</div>");
                Response.Write("    <div class='image'>");
                Response.Write("        <img class='' alt='product image' src='" + row.Cells[7].Text + "' width='300' height='300'>");
                Response.Write("    </div>");
                Response.Write("    <div class='description'>");
                Response.Write("        <p>" + row.Cells[10].Text + "</p>");
                Response.Write("    </div>");
                Response.Write("    <div class='Phone_Number'>");
                Response.Write("        <p>מספר טלפון: " + us.GetPhoneNumberByUserName(name) + "</p>");
                Response.Write("    </div>");
                Response.Write("    <div class='Seller_Name'>");
                Response.Write("        <p>שם המוכר: " + name + "</p>");
                Response.Write("    </div>");
                Response.Write("    <div class='Usage_Level'>");
                Response.Write("        <p>רמת השימוש: " + filteProducts.GetConditionById(row.Cells[8].Text) + "</p>");
                Response.Write("    </div>");
                Response.Write("    <div class='Categorys'>");
                Response.Write("        <p>קטגוריה: " + filteProducts.GetCategoryById(row.Cells[4].Text) + "</p>");
                Response.Write("    </div>");
                Response.Write("    <div class='Price'>");
                Response.Write("        <p>מחיר: " + row.Cells[9].Text + "</p>");
                Response.Write("    </div>");
                Response.Write("</div>");
            }
            else
            {
                name = us.GetUsernameById(row.Cells[2].Text);
                Response.Write("<div class='blocks'>");
                Response.Write("    <div class='Blocklbl'>");
                Response.Write("        <p>" + row.Cells[1].Text + "</p>");
                Response.Write("    </div>");
                Response.Write("<div>");
                Response.Write("    <button onclick='AddToFavorite()' class='InvisableButton'>");
                Response.Write("        <img id='" + row.Cells[0].Text + "' src='../img/heart-Logo.png' class='ImgBlack CartLogo' />");
                Response.Write("    </button>");
                Response.Write("</div>");
                Response.Write("    <div class='image'>");
                Response.Write("        <img class='' alt='product image' src='" + row.Cells[7].Text + "' width='300' height='300'>");
                Response.Write("    </div>");
                Response.Write("    <div class='description'>");
                Response.Write("        <p>" + row.Cells[10].Text + "</p>");
                Response.Write("    </div>");
                Response.Write("    <div class='Phone_Number'>");
                Response.Write("        <p>מספר טלפון: " + us.GetPhoneNumberByUserName(name) + "</p>");
                Response.Write("    </div>");
                Response.Write("    <div class='Seller_Name'>");
                Response.Write("        <p>שם המוכר: " + name + "</p>");
                Response.Write("    </div>");
                Response.Write("    <div class='Usage_Level'>");
                Response.Write("        <p>רמת השימוש: " + filteProducts.GetConditionById(row.Cells[8].Text) + "</p>");
                Response.Write("    </div>");
                Response.Write("    <div class='Categorys'>");
                Response.Write("        <p>קטגוריה: " + filteProducts.GetCategoryById(row.Cells[4].Text) + "</p>");
                Response.Write("    </div>");
                Response.Write("    <div class='Price'>");
                Response.Write("        <p>מחיר: " + row.Cells[9].Text + "</p>");
                Response.Write("    </div>");
                Response.Write("</div>");
            }
        }
            Response.Write("</div>");
        //Response.Write("</div>");
    }
    //public void Blocks()
    //{
    //    if (!Filter)
    //    {
    //        users us = new users();
    //        // מכניס נתונים לטבלה
    //        Products allproducts = new Products();
    //        grd_AllProducts.DataSource = allproducts.AllProducts(allproducts);
    //        grd_AllProducts.DataBind();
    //        string name = "";
    //        // מעלה את הנתונים מהטבלה לצורה יפה
    //        foreach (GridViewRow row in grd_AllProducts.Rows)
    //        {
    //            if (Session["userName"] == null)
    //            {
    //                name = us.GetUsernameById(row.Cells[2].Text);
    //                Response.Write("<div class='blocks'>");
    //                Response.Write("    <div class='Blocklbl'>");
    //                Response.Write("        <p>" + row.Cells[1].Text + "</p>");
    //                Response.Write("    </div>");
    //                Response.Write("<div>");
    //                Response.Write("    <button onclick='AddToFavorite()' class='InvisableButton'>");
    //                Response.Write("        <img id='" + row.Cells[0].Text + "' src='../img/heart-Logo.png' class='ImgBlack CartLogo' />");
    //                Response.Write("    </button>");
    //                Response.Write("</div>");
    //                Response.Write("    <div class='image'>");
    //                Response.Write("        <img class='' alt='product image' src='" + row.Cells[7].Text + "' width='300' height='300'>");
    //                Response.Write("    </div>");
    //                Response.Write("    <div class='description'>");
    //                Response.Write("        <p>" + row.Cells[10].Text + "</p>");
    //                Response.Write("    </div>");
    //                Response.Write("    <div class='Phone_Number'>");
    //                Response.Write("        <p>מספר טלפון: " + us.GetPhoneNumberByUserName(name) + "</p>");
    //                Response.Write("    </div>");
    //                Response.Write("    <div class='Seller_Name'>");
    //                Response.Write("        <p>שם המוכר: " + name + "</p>");
    //                Response.Write("    </div>");
    //                Response.Write("    <div class='Usage_Level'>");
    //                Response.Write("        <p>רמת השימוש: " + allproducts.GetConditionById(row.Cells[8].Text) + "</p>");
    //                Response.Write("    </div>");
    //                Response.Write("    <div class='Categorys'>");
    //                Response.Write("        <p>קטגוריה: " + allproducts.GetCategoryById(row.Cells[4].Text) + "</p>");
    //                Response.Write("    </div>");
    //                Response.Write("    <div class='Price'>");
    //                Response.Write("        <p>מחיר: " + row.Cells[9].Text + "</p>");
    //                Response.Write("    </div>");
    //                Response.Write("</div>");
    //            }
    //            else if (allproducts.IsFavoriteProductsExists(Session["userName"].ToString(), row.Cells[0].Text))
    //            {
    //                name = us.GetUsernameById(row.Cells[2].Text);
    //                Response.Write("<div class='blocks'>");
    //                Response.Write("    <div class='Blocklbl'>");
    //                Response.Write("        <p>" + row.Cells[1].Text + "</p>");
    //                Response.Write("    </div>");
    //                Response.Write("<div>");
    //                Response.Write("    <button onclick='AddToFavorite()' class='InvisableButton'>");
    //                Response.Write("        <img id='"+row.Cells[0].Text+"' src='../img/heart-Logo.png' class='CartLogo' />");
    //                Response.Write("    </button>");
    //                Response.Write("</div>");
    //                Response.Write("    <div class='image'>");
    //                Response.Write("        <img class='' alt='product image' src='" + row.Cells[7].Text + "' width='300' height='300'>");
    //                Response.Write("    </div>");
    //                Response.Write("    <div class='description'>");
    //                Response.Write("        <p>" + row.Cells[10].Text + "</p>");
    //                Response.Write("    </div>");
    //                Response.Write("    <div class='Phone_Number'>");
    //                Response.Write("        <p>מספר טלפון: " + us.GetPhoneNumberByUserName(name) + "</p>");
    //                Response.Write("    </div>");
    //                Response.Write("    <div class='Seller_Name'>");
    //                Response.Write("        <p>שם המוכר: " + name + "</p>");
    //                Response.Write("    </div>");
    //                Response.Write("    <div class='Usage_Level'>");
    //                Response.Write("        <p>רמת השימוש: " + allproducts.GetConditionById(row.Cells[8].Text) + "</p>");
    //                Response.Write("    </div>");
    //                Response.Write("    <div class='Categorys'>");
    //                Response.Write("        <p>קטגוריה: " + allproducts.GetCategoryById(row.Cells[4].Text) + "</p>");
    //                Response.Write("    </div>");
    //                Response.Write("    <div class='Price'>");
    //                Response.Write("        <p>מחיר: " + row.Cells[9].Text + "</p>");
    //                Response.Write("    </div>");
    //                Response.Write("</div>");
    //            }
    //            else
    //            {
    //                name = us.GetUsernameById(row.Cells[2].Text);
    //                Response.Write("<div class='blocks'>");
    //                Response.Write("    <div class='Blocklbl'>");
    //                Response.Write("        <p>" + row.Cells[1].Text + "</p>");
    //                Response.Write("    </div>");
    //                Response.Write("<div>");
    //                Response.Write("    <button onclick='AddToFavorite()' class='InvisableButton'>");
    //                Response.Write("        <img id='" + row.Cells[0].Text + "' src='../img/heart-Logo.png' class='ImgBlack CartLogo' />");
    //                Response.Write("    </button>");
    //                Response.Write("</div>");
    //                Response.Write("    <div class='image'>");
    //                Response.Write("        <img class='' alt='product image' src='" + row.Cells[7].Text + "' width='300' height='300'>");
    //                Response.Write("    </div>");
    //                Response.Write("    <div class='description'>");
    //                Response.Write("        <p>" + row.Cells[10].Text + "</p>");
    //                Response.Write("    </div>");
    //                Response.Write("    <div class='Phone_Number'>");
    //                Response.Write("        <p>מספר טלפון: " + us.GetPhoneNumberByUserName(name) + "</p>");
    //                Response.Write("    </div>");
    //                Response.Write("    <div class='Seller_Name'>");
    //                Response.Write("        <p>שם המוכר: " + name + "</p>");
    //                Response.Write("    </div>");
    //                Response.Write("    <div class='Usage_Level'>");
    //                Response.Write("        <p>רמת השימוש: " + allproducts.GetConditionById(row.Cells[8].Text) + "</p>");
    //                Response.Write("    </div>");
    //                Response.Write("    <div class='Categorys'>");
    //                Response.Write("        <p>קטגוריה: " + allproducts.GetCategoryById(row.Cells[4].Text) + "</p>");
    //                Response.Write("    </div>");
    //                Response.Write("    <div class='Price'>");
    //                Response.Write("        <p>מחיר: " + row.Cells[9].Text + "</p>");
    //                Response.Write("    </div>");
    //                Response.Write("</div>");
    //            }
    //        }
    //    }
    //}



    protected void btn_allProducts_Click(object sender, EventArgs e)
    {
    }

    protected void ib_Heart_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["userName"] != null)
            Response.Redirect("./LovedProducts.aspx");
    }

    protected void btn_ContactUs_Click(object sender, EventArgs e)
    {
        Response.Redirect("./ContactUs.aspx");
    }

    protected void btn_Admin_goto_Click(object sender, EventArgs e)
    {
        Response.Redirect("../Admin/IndexAdmin.aspx");
    }
    protected void btn_MyProducts_Click(object sender, EventArgs e)
    {
        Response.Redirect("./MyProducts.aspx");
    }

    protected void btn_UpdateUserInfo_Click(object sender, EventArgs e)
    {
        //מונע מהדף לרוץ פעמיים ולאבד את העדכון
        Session["yy"] = false;
        Response.Redirect("./UpdateUserInfo.aspx");
    }

    protected void btn_AddToFavorite_Click(object sender, EventArgs e)
    {
        //TestLBL.Text = "Good " + Session["FavoriteId"].ToString() ;
    }
    public void GetButtonId(object sender, EventArgs e)
    {
        string idFavorite = lbl_FavoriteId.Text;
        Console.WriteLine(idFavorite);
        //TestLBL.Text = buttonId;
    }



    protected void btn_Catalog2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/User/Catalog2/Catalog2.aspx");
    }

    protected void btn_DonateGoTo_Click(object sender, EventArgs e)
    {
        Response.Redirect("./Donate.aspx");
    }

    protected void Unnamed2_Click(object sender, ImageClickEventArgs e)
    {
        // מכניס נתונים לטבלה
        Products filteProducts = new Products();
        grd_AllProducts.DataSource = filteProducts.SearchProducts(txt_search.Text.ToString());
        grd_AllProducts.DataBind();
        foreach (GridViewRow row in grd_AllProducts.Rows)
        {
            imgb_SearchedImage.ImageUrl = row.Cells[1].Text;
        }
        imgb_SearchedImage.Visible = true;
    }

    protected void imgb_SearchedImage_Click(object sender, ImageClickEventArgs e)
    {
        string imgId = "";
        Products filteProducts = new Products();
        grd_AllProducts.DataSource = filteProducts.SearchProducts(txt_search.Text.ToString());
        grd_AllProducts.DataBind();
        foreach (GridViewRow row in grd_AllProducts.Rows)
        {
            imgId = row.Cells[1].Text;
        }
        grd_productbyimg.DataSource = filteProducts.SearchProductsByImg(imgId);
        grd_productbyimg.DataBind();
        pnl_product.Visible = true;
        foreach (GridViewRow row in grd_productbyimg.Rows)
        {
            
            img_Product.ImageUrl= row.Cells[3].Text;
            txt_productId.Text = row.Cells[0].Text;
            txt_ProductTitle.Text = row.Cells[1].Text;
            txt_ProductPrice.Text = row.Cells[2].Text;
        }
        Products allproducts = new Products();
        grd_AllProducts.DataSource = allproducts.AllProducts(allproducts);
        grd_AllProducts.DataBind();
        Random r = new Random();
        r.Next(0, grd_AllProducts.Rows.Count - 1);
        foreach (GridViewRow row in grd_AllProducts.Rows)
        {
            if (row.RowIndex == r.Next(0, grd_AllProducts.Rows.Count - 1))
                imgb_1.ImageUrl = row.Cells[7].Text;
        }
        foreach (GridViewRow row in grd_AllProducts.Rows)
        {
            if (row.RowIndex == r.Next(0, grd_AllProducts.Rows.Count - 1))
                imgb_2.ImageUrl = row.Cells[7].Text;
        }
        foreach (GridViewRow row in grd_AllProducts.Rows)
        {
            if (row.RowIndex == r.Next(0, grd_AllProducts.Rows.Count - 1))
                imgb_3.ImageUrl = row.Cells[7].Text;
        }
        imgb_1.Visible = true;
        imgb_2.Visible = true;
        imgb_3.Visible = true;
    }

    protected void grd_productbyimg_SelectedIndexChanged(object sender, EventArgs e)
    {
        int amount = ddl_Amount.SelectedIndex; int textbox = int.Parse(txt_ProductPrice.Text);
        int Total = amount * textbox;
        txt_Total.Text = Total.ToString();
    }

    protected void imgb_1_Click(object sender, ImageClickEventArgs e)
    {
        Products filteProducts = new Products();
        grd_productbyimg.DataSource = filteProducts.SearchProductsByImg(imgb_1.ImageUrl.ToString());
        grd_productbyimg.DataBind();
        pnl_product.Visible = true;
        foreach (GridViewRow row in grd_productbyimg.Rows)
        {

            img_Product.ImageUrl = row.Cells[3].Text;
            txt_productId.Text = row.Cells[0].Text;
            txt_ProductTitle.Text = row.Cells[1].Text;
            txt_ProductPrice.Text = row.Cells[2].Text;
        }
        Products allproducts = new Products();
        grd_AllProducts.DataSource = allproducts.AllProducts(allproducts);
        grd_AllProducts.DataBind();
        Random r = new Random();
        r.Next(0, grd_AllProducts.Rows.Count - 1);
        foreach (GridViewRow row in grd_AllProducts.Rows)
        {
            if (row.RowIndex == r.Next(0, grd_AllProducts.Rows.Count - 1))
                imgb_1.ImageUrl = row.Cells[7].Text;
        }
        foreach (GridViewRow row in grd_AllProducts.Rows)
        {
            if (row.RowIndex == r.Next(0, grd_AllProducts.Rows.Count - 1))
                imgb_2.ImageUrl = row.Cells[7].Text;
        }
        foreach (GridViewRow row in grd_AllProducts.Rows)
        {
            if (row.RowIndex == r.Next(0, grd_AllProducts.Rows.Count - 1))
                imgb_3.ImageUrl = row.Cells[7].Text;
        }
        imgb_1.Visible = true;
        imgb_2.Visible = true;
        imgb_3.Visible = true;
    }

    protected void imgb_2_Click(object sender, ImageClickEventArgs e)
    {
        Products filteProducts = new Products();
        grd_productbyimg.DataSource = filteProducts.SearchProductsByImg(imgb_2.ImageUrl.ToString());
        grd_productbyimg.DataBind();
        pnl_product.Visible = true;
        foreach (GridViewRow row in grd_productbyimg.Rows)
        {

            img_Product.ImageUrl = row.Cells[3].Text;
            txt_productId.Text = row.Cells[0].Text;
            txt_ProductTitle.Text = row.Cells[1].Text;
            txt_ProductPrice.Text = row.Cells[2].Text;
        }
        Products allproducts = new Products();
        grd_AllProducts.DataSource = allproducts.AllProducts(allproducts);
        grd_AllProducts.DataBind();
        Random r = new Random();
        r.Next(0, grd_AllProducts.Rows.Count - 1);
        foreach (GridViewRow row in grd_AllProducts.Rows)
        {
            if (row.RowIndex == r.Next(0, grd_AllProducts.Rows.Count - 1))
                imgb_1.ImageUrl = row.Cells[7].Text;
        }
        foreach (GridViewRow row in grd_AllProducts.Rows)
        {
            if (row.RowIndex == r.Next(0, grd_AllProducts.Rows.Count - 1))
                imgb_2.ImageUrl = row.Cells[7].Text;
        }
        foreach (GridViewRow row in grd_AllProducts.Rows)
        {
            if (row.RowIndex == r.Next(0, grd_AllProducts.Rows.Count - 1))
                imgb_3.ImageUrl = row.Cells[7].Text;
        }
        imgb_1.Visible = true;
        imgb_2.Visible = true;
        imgb_3.Visible = true;

    }

    protected void imgb_3_Click(object sender, ImageClickEventArgs e)
    {
        Products filteProducts = new Products();
        grd_productbyimg.DataSource = filteProducts.SearchProductsByImg(imgb_3.ImageUrl.ToString());
        grd_productbyimg.DataBind();
        pnl_product.Visible = true;
        foreach (GridViewRow row in grd_productbyimg.Rows)
        {

            img_Product.ImageUrl = row.Cells[3].Text;
            txt_productId.Text = row.Cells[0].Text;
            txt_ProductTitle.Text = row.Cells[1].Text;
            txt_ProductPrice.Text = row.Cells[2].Text;
        }
        Products allproducts = new Products();
        grd_AllProducts.DataSource = allproducts.AllProducts(allproducts);
        grd_AllProducts.DataBind();
        Random r = new Random();
        r.Next(0, grd_AllProducts.Rows.Count - 1);
        foreach (GridViewRow row in grd_AllProducts.Rows)
        {
            if (row.RowIndex == r.Next(0, grd_AllProducts.Rows.Count - 1))
                imgb_1.ImageUrl = row.Cells[7].Text;
        }
        foreach (GridViewRow row in grd_AllProducts.Rows)
        {
            if (row.RowIndex == r.Next(0, grd_AllProducts.Rows.Count - 1))
                imgb_2.ImageUrl = row.Cells[7].Text;
        }
        foreach (GridViewRow row in grd_AllProducts.Rows)
        {
            if (row.RowIndex == r.Next(0, grd_AllProducts.Rows.Count - 1))
                imgb_3.ImageUrl = row.Cells[7].Text;
        }
        imgb_1.Visible = true;
        imgb_2.Visible = true;
        imgb_3.Visible = true;
    }

    protected void ddl_Amount_SelectedIndexChanged(object sender, EventArgs e)
    {
        int amount = ddl_Amount.SelectedIndex; int textbox = int.Parse(txt_ProductPrice.Text);
        int Total = amount * textbox;
        txt_Total.Text = Total.ToString();
    }
}