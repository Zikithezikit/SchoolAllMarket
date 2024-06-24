using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_loginadmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Lbl_err.Visible = false;
    }

    protected void Btn_adminlogin_Click(object sender, EventArgs e)
    {
        users loginUs = new users();
        loginUs.User_Name = Txt_adminuser.Text;
        loginUs.Pass = Txt_adminpass.Text;
        if (loginUs.loginAdmin(loginUs))
        {
            Session["adminuser"] = Txt_adminuser.Text;
            Response.Redirect("adminmenu.aspx");
        }
        else Lbl_err.Visible = true;
    }
}