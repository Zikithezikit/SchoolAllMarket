using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_typeBooksForPanelCatalog : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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

    protected void btn_index_Click(object sender, EventArgs e)
    {
        Response.Redirect("index.aspx");
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Session["booktype"] = "ילדים";
        Response.Redirect("GridViewcatalog.aspx");
    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Session["booktype"]="פנטזיה";
        Response.Redirect("GridViewcatalog.aspx");
    }

    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        Session["booktype"] = "קומדיה";
        Response.Redirect("GridViewcatalog.aspx");
    }
}