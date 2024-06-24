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
        grid_City.Visible = false;
        lbl_NoUsers.Visible = false;


    }

    protected void ddl_City_SelectedIndexChanged(object sender, EventArgs e)
    {
        users User1 = new users();
        grid_City.DataSource = User1.GetUsersByCity(ddl_City.SelectedItem.ToString()).Tables[0];
        grid_City.DataBind();
        lbl_NoUsers.Text = ddl_City.SelectedItem.ToString();
        if (grid_City.Rows.Count == 0)
        {
            lbl_NoUsers.Visible = true;
            lbl_NoUsers.Text = "אין משתמשים בעיר הזו";
        }
        else
        {
            grid_City.Visible = true;
            lbl_NoUsers.Visible = true;
            lbl_NoUsers.Text = "כמות המשתמשים: " + grid_City.Rows.Count;
        }
    }

    protected void btn_IndexAdmin_Click(object sender, EventArgs e)
    {
        Response.Redirect("./IndexAdmin.aspx");
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