using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_IndexAdmin : System.Web.UI.Page
{
    users Adminuser = new users();
    protected void Page_Load(object sender, EventArgs e)
    {
        lbl_Countusers.Text = "מספר המשתמשים באתר כרגע הוא: " + Adminuser.GetNumberOfUsers().ToString();
    }

    protected void btn_Userlistbycities_Click(object sender, EventArgs e)
    {
        Response.Redirect("./Userlistbycities.aspx");
    }

    protected void btn_Userlistbygender_Click(object sender, EventArgs e)
    {
        Response.Redirect("./Userlistbygender.aspx");
    }
    protected void btn_Index_Click(object sender, EventArgs e)
    {
        Response.Redirect("../User/Index.aspx");
    }
}