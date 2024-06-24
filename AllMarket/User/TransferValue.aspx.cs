using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;

public partial class User_TransferValue : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string userValue = HttpContext.Current.Request.QueryString["userValue"].ToString();
        string userName = HttpContext.Current.Request.QueryString["userName"].ToString();
        lbl_ID_1.Text = userValue;
        lbl_ID_2.Text = userName;
        Products Favorite = new Products();
        if (!(Favorite.IsFavoriteProductsExists(userName, userValue)))
            Favorite.AddToFavorite(userValue, userName);

        System.Web.HttpContext.Current.Response.Write("<script>if(window.opener){window.opener.location.reload(true);}</script>");
        System.Web.HttpContext.Current.Response.Write("<script>self.close();</script>");
    }
    
}