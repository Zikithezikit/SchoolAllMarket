using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Userlistbycities : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        users ISAdmin = new users();
        if (!(Session["userName"] != null && ISAdmin.Isadmin(Session["userName"].ToString()))) Response.Redirect("../User/Index.aspx");
        grid_gender.Visible = false;
        lbl_NoUsers.Visible = false;


    }

    protected void ddl_City_SelectedIndexChanged(object sender, EventArgs e)
    {
        users User1 = new users();
        grid_gender.DataSource = User1.GetUserByGender(ddl_gender.SelectedItem.ToString()).Tables[0];
        grid_gender.DataBind();
        lbl_NoUsers.Text = ddl_gender.SelectedItem.ToString();
        if (grid_gender.Rows.Count == 0)
        {
            lbl_NoUsers.Visible = true;
            lbl_NoUsers.Text = "אין משתמשים במין זה";
        }
        else
        {
            grid_gender.Visible = true;
            lbl_NoUsers.Visible = true;
            lbl_NoUsers.Text = "כמות המשתמשים: " + grid_gender.Rows.Count;
        }
    }

    protected void btn_IndexAdmin_Click(object sender, EventArgs e)
    {
        Response.Redirect("./IndexAdmin.aspx");
    }

    protected void btn_Userlistbycities_Click(object sender, EventArgs e)
    {
        Response.Redirect("./Userlistbycities.aspx");
    }
    protected void btn_Index_Click(object sender, EventArgs e)
    {
        Response.Redirect("../User/Index.aspx");
    }
}