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

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Session["type"] = "ילדים";
        Response.Redirect("panelsCatalog2.aspx");
    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Session["type"] = "פנטזיה";
        Response.Redirect("panelsCatalog2.aspx");
    }

    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        Session["type"] = "קומדיה";
        Response.Redirect("panelsCatalog2.aspx");
    }
}