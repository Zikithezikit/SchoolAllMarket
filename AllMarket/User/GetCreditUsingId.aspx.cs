using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_GetCreditUsingId : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userName"] == null) Response.Redirect("./Index.aspx");
    }
    protected void btn_Index_Click(object sender, EventArgs e)
    {
        Response.Redirect("./Index.aspx");
    }

    protected void btn_GetCredit_Click(object sender, EventArgs e)
    {
        ServiceReference1.ServiceSoapClient BankServer = new ServiceReference1.ServiceSoapClient();
        grd_Credit.DataSource = BankServer.chkInfo(txt_Id.Text);
        grd_Credit.DataBind();

        foreach (GridViewRow row in grd_Credit.Rows)
        {
            txt_CardNumber.Text = row.Cells[1].Text;
            txt_Month.Text = row.Cells[2].Text;
            ddl_CardType.Text = row.Cells[3].Text;
            txt_CVC.Text = row.Cells[4].Text;
            txt_Year.Text = row.Cells[9].Text;
        }
        txt_CardNumber.Visible = true;
        txt_Month.Visible = true;
        ddl_CardType.Visible = true;
        txt_CVC.Visible = true;
        txt_Year.Visible = true;
    }
}