using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_DeleteProduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string userValue = HttpContext.Current.Request.QueryString["userValue"].ToString();
        Products DeleteFromAllProducts = new Products();
        DeleteFromAllProducts.DeleteFromAllProducts(userValue);


        System.Web.HttpContext.Current.Response.Write("<script>if(window.opener){window.opener.location.reload(true);}</script>");
        System.Web.HttpContext.Current.Response.Write("<script>self.close();</script>");
    }
}