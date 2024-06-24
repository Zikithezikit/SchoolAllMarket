using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


    }

    protected void btn_Login_Click(object sender, EventArgs e)
    {
        users loginUs = new users();
        loginUs.User_Name = txt_Username.Text;
        loginUs.Pass = txt_Password.Text;
        if (loginUs.loginuser(loginUs))
        {
            Session["userName"] = txt_Username.Text;
            Response.Redirect("~/User/Index.aspx");
        }
        else lbl_error.Visible = true;
    }
    public void btn_GuestClick(Object sender, EventArgs e)
    {
        Session["userName"] = null;
        Response.Redirect("./Index.aspx");
    }
}