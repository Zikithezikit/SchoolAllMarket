using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_userlistbycities : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        grd_Details.Visible = false;
        lbl_user.Visible = false;
    }

    protected void ddl_city_SelectedIndexChanged(object sender, EventArgs e)
    {
        users userCity = new users();
        userCity.CityName = ddl_city.SelectedItem.Text;
        grd_Details.DataSource = userCity.userbycity(userCity).Tables[0];
        grd_Details.DataBind();
        if (grd_Details.Rows.Count == 0) {
            lbl_user.Visible = true;
            lbl_user.Text = "אין משתמשים בעיר זו";
        }
        else
        {
            grd_Details.Visible = true;
            lbl_user.Text = "כמות המשתמשים: " + grd_Details.Rows.Count;
        }
    }
}