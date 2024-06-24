using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_Catalog2_Catalog2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
    protected void ib_Heart_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["userName"] != null)
            Response.Redirect("./LovedProducts.aspx");
    }

    protected void btn_ContactUs_Click(object sender, EventArgs e)
    {
        Response.Redirect("../ContactUs.aspx");
    }

    protected void btn_Admin_goto_Click(object sender, EventArgs e)
    {
        Response.Redirect("../../Admin/IndexAdmin.aspx");
    }
    protected void btn_MyProducts_Click(object sender, EventArgs e)
    {
        Response.Redirect("../MyProducts.aspx");
    }
    protected void btn_Index_Click(object sender, EventArgs e)
    {
        Response.Redirect("../Index.aspx");
    }

    protected void btn_UpdateUserInfo_Click(object sender, EventArgs e)
    {
        //מונע מהדף לרוץ פעמיים ולאבד את העדכון
        Session["yy"] = false;
        Response.Redirect("./UpdateUserInfo.aspx");
    }
    public void Blocks()
    {
            users us = new users();
            // מכניס נתונים לטבלה
            Products allproducts = new Products();
            grd_AllProducts.DataSource = allproducts.AllProducts(allproducts);
            grd_AllProducts.DataBind();
            string name = "";
            // מעלה את הנתונים מהטבלה לצורה יפה
            foreach (GridViewRow row in grd_AllProducts.Rows)
            {
                if (Session["userName"] == null)
                {
                    name = us.GetUsernameById(row.Cells[2].Text);
                    Response.Write("<div class='blocks'>");
                    Response.Write("    <div class='Blocklbl'>");
                    Response.Write("        <p>" + row.Cells[1].Text + "</p>");
                    Response.Write("    </div>");
                    Response.Write("<div>");
                    //Response.Write("    <button onclick='AddToFavorite()' class='InvisableButton'>");
                    //Response.Write("        <img id='" + row.Cells[0].Text + "' src='../img/heart-Logo.png' class='ImgBlack CartLogo' />");
                    //Response.Write("    </button>");
                    Response.Write("</div>");
                    Response.Write("    <div class='image'>");
                    Response.Write("        <img class='' alt='product image' src='../" + row.Cells[7].Text + "' width='150' height='150'>");
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
                    Response.Write("        <p>רמת השימוש: " + allproducts.GetConditionById(row.Cells[8].Text) + "</p>");
                    Response.Write("    </div>");
                    Response.Write("    <div class='Categorys'>");
                    Response.Write("        <p>קטגוריה: " + allproducts.GetCategoryById(row.Cells[4].Text) + "</p>");
                    Response.Write("    </div>");
                    Response.Write("    <div class='Price'>");
                    Response.Write("        <p>מחיר: " + row.Cells[9].Text + "</p>");
                    Response.Write("    </div>");
                    Response.Write("</div>");
                }
                else if (allproducts.IsFavoriteProductsExists(Session["userName"].ToString(), row.Cells[0].Text))
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
                    Response.Write("        <p>רמת השימוש: " + allproducts.GetConditionById(row.Cells[8].Text) + "</p>");
                    Response.Write("    </div>");
                    Response.Write("    <div class='Categorys'>");
                    Response.Write("        <p>קטגוריה: " + allproducts.GetCategoryById(row.Cells[4].Text) + "</p>");
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
                    Response.Write("        <p>רמת השימוש: " + allproducts.GetConditionById(row.Cells[8].Text) + "</p>");
                    Response.Write("    </div>");
                    Response.Write("    <div class='Categorys'>");
                    Response.Write("        <p>קטגוריה: " + allproducts.GetCategoryById(row.Cells[4].Text) + "</p>");
                    Response.Write("    </div>");
                    Response.Write("    <div class='Price'>");
                    Response.Write("        <p>מחיר: " + row.Cells[9].Text + "</p>");
                    Response.Write("    </div>");
                    Response.Write("</div>");
                }
            }
    }
}