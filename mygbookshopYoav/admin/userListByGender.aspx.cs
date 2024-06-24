using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_userListByGender : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        grd_Details.Visible = false;
        Label2.Visible = false;
    }

    protected void ddl_gender_SelectedIndexChanged(object sender, EventArgs e)
    {
        users userGender = new users();
        userGender.Gender = ddl_gender.SelectedItem.Text;
        grd_Details.DataSource = userGender.usersbygender(userGender).Tables[0];
        grd_Details.DataBind();
        if (grd_Details.Rows.Count == 0)
        {
            Label2.Visible = true;
            Label2.Text = "אין משתמשים ממין זה";
        }
        else
        {
            grd_Details.Visible = true;
            Label2.Visible = true;
            Label2.Text = "כמות המשתמשים: " + grd_Details.Rows.Count;
        }
    }
}