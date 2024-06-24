using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["user"] != null)
        {
            lblwellcome.Text = Session["user"] + " שלום";
            im_cart.Visible = true;
            lbl_AmountOfItems.Visible = true;
            users u = new users();
            lbl_AmountOfItems.Text = u.GetAmountOfOrderByUserName(Session["user"].ToString()).ToString();
        }
        else
        {
            lblwellcome.Text = "שלום אורח";
            im_cart.Visible = false;
            lbl_AmountOfItems.Visible = false;
        }
    }

    protected void btn_pnl_books_Click(object sender, EventArgs e)
    {
        Response.Redirect("./typeBooksForPanelCatalog.aspx");
    }

    protected void btn_register_Click(object sender, EventArgs e)
    {
        Response.Redirect("./register.aspx");
    }

    protected void btn_login_Click(object sender, EventArgs e)
    {
        Response.Redirect("./loginuser.aspx");
    }

    protected void btn_Admin_Click(object sender, EventArgs e)
    {
        Response.Redirect("../admin/loginadmin.aspx");
    }

    protected void btn_grd_Click(object sender, EventArgs e)
    {
        Response.Redirect("typeBookForGridviewcatalog.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("myCart.aspx");
    }

    protected void im_cart_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("./myCart.aspx");
    }
}