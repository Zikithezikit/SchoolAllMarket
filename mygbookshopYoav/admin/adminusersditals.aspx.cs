using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_adminusersditals : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Grd_dittals.Visible = true;
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        users user = new users();
        user.User_Name = Ddl_username.SelectedItem.Text;
        Grd_dittals.DataSource = user.USERNAME(user);
        Grd_dittals.DataBind();
        Grd_dittals.Visible = true;
        
        if (Grd_dittals.Rows.Count != 0)
        {
            Grd_dittals.Visible = true;
        }
    }
}

        