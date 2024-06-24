using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_LovedProducts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userName"] == null) Response.Redirect("./Index.aspx");
        lbl_UserName.Text = Session["userName"].ToString();
    }
    protected void btn_index_Click(object sender, EventArgs e)
    {
        Response.Redirect("./Index.aspx");
    }
    public void Blocks()
    {
        
            users us = new users();
            // מכניס נתונים לטבלה
            Products FavoriteUser = new Products();
            grd_Favorite.DataSource = FavoriteUser.GetFavotiteProductsOfUserByUserName(Session["userName"].ToString());
            grd_Favorite.DataBind();
            string name = "";
            // מעלה את הנתונים מהטבלה לצורה יפה
            foreach (GridViewRow row in grd_Favorite.Rows)
            {
                name = us.GetUsernameById(row.Cells[3].Text);
                Response.Write("<div class='blocks'>");
                Response.Write("    <div class='Blocklbl'>");
                Response.Write("        <p>" + row.Cells[2].Text + "</p>");
                Response.Write("    </div>");
                Response.Write("<div>");
                Response.Write("    <button onclick='DeleteFavorite()' class='InvisableButton'>");
                Response.Write("        <img id='" + row.Cells[1].Text + "' src='../img/heart-Logo.png' class='CartLogo' />");
                Response.Write("    </button>");
                Response.Write("</div>");
                Response.Write("    <div class='image'>");
                Response.Write("        <img alt='product image' src='" + row.Cells[8].Text + "' width='300' height='300'>");
                Response.Write("    </div>");
                Response.Write("    <div class='description'>");
                Response.Write("        <p>" + row.Cells[11].Text + "</p>");
                Response.Write("    </div>");
                Response.Write("    <div class='Phone_Number'>");
                Response.Write("        <p>מספר טלפון: " + us.GetPhoneNumberByUserName(name) + "</p>");
                Response.Write("    </div>");
                Response.Write("    <div class='Seller_Name'>");
                Response.Write("        <p>שם המוכר: " + name + "</p>");
                Response.Write("    </div>");
                Response.Write("    <div class='Usage_Level'>");
                Response.Write("        <p>רמת השימוש: " + FavoriteUser.GetConditionById(row.Cells[9].Text) + "</p>");
                Response.Write("    </div>");
                Response.Write("    <div class='Categorys'>");
                Response.Write("        <p>קטגוריה: " + FavoriteUser.GetCategoryById(row.Cells[5].Text) + "</p>");
                Response.Write("    </div>");
                Response.Write("    <div class='Price'>");
                Response.Write("        <p>מחיר: " + row.Cells[10].Text + "</p>");
                Response.Write("    </div>");
                Response.Write("</div>");
            }
        
    }

}