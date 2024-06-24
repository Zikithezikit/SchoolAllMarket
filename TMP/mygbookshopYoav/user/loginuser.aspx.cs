using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_loginuser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lbl_succ.Visible = false;
    }


    protected void Btn_login_Click(object sender, EventArgs e)
    {
        users loginUs = new users();
        loginUs.User_Name = Txt_user.Text;
        loginUs.Pass = Txt_pass.Text;
        if (loginUs.loginuser(loginUs))
        {
            Session["user"] = Txt_user.Text;
            Response.Redirect("index.aspx");
        }
        else lbl_succ.Visible = true;
    }
}