using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_SearchOrderByUsername : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["adminuser"] == null)
        {
            Response.Redirect("loginadmin.aspx");
        }

    }
    protected void ShowGrdDetails(object sender, GridViewCommandEventArgs e)
    {
        grd_Details.Visible = true;
        orders order = new orders();
        int row = Convert.ToInt32(e.CommandArgument);
        lbl_Error.Text = grd_ByName.Rows[row].Cells[2].ToString();
        //grd_Details.DataSource = order.GetDetailsByOrderId(grd_ByName.Rows[row].Cells[2].ToString());
        //grd_Details.DataBind();
    }
    
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        grd_ByName.Visible = true;
        orders order = new orders();
        grd_ByName.DataSource = order.GetOrdersByName(DropDownList1.SelectedValue.ToString());
        grd_ByName.DataBind();
    }

    protected void grd_ByName_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
}