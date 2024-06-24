using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// מרחב השמות בהם נמצאות המחלקות הטפלות בבסיס הנתונים בהן אנו נעזרים בשאילתות ממסד הנתונים
using System.Data;
using System.Data.OleDb;

public partial class user_panelsCatalog2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["type"]==null)
            Response.Redirect("typeBooksForPanelCatalog.aspx");
        DataSet dsbooks = new DataSet();
        books bk = new books();
        bk.BookType = Session["type"].ToString();
        dsbooks = bk.getBooks(bk);
        if (dsbooks.Tables[0].Rows.Count >= 0)
        {
            pnlBook.Visible = false;
            pnlBook1.Visible = false;
            pnlBook2.Visible = false;
            pnlBook3.Visible = false;
            pnlBook4.Visible = false;
            pnlBook5.Visible = false; 
        }
        if (dsbooks.Tables[0].Rows.Count >= 1)
        {
            pnlBook1.Visible = true;
            pnlBook.Visible = false;
            pnlBook2.Visible = false;
            pnlBook3.Visible = false;
            pnlBook4.Visible = false;
            pnlBook5.Visible = false;
            txtbookId1.Text = dsbooks.Tables[0].Rows[0][0].ToString();
            txt_bookname1.Text=dsbooks.Tables[0].Rows[0][1].ToString();
            txt_book_price1.Text = dsbooks.Tables[0].Rows[0][2].ToString();
            Image3.ImageUrl = dsbooks.Tables[0].Rows[0][3].ToString();
            txtTotal1.Text = txt_book_price1.Text;
        }
    }

    protected void btnEnd1_Click(object sender, EventArgs e)
    {
        Response.Redirect("myCart.aspx");
    }

    protected void ddlAmount1_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtTotal1.Text = (int.Parse(txt_book_price1.Text) * int.Parse(ddlAmount1.SelectedValue.ToString())).ToString();
    }

    protected void btnEnd2_Click(object sender, EventArgs e)
    {
        Response.Redirect("myCart.aspx");
    }

    protected void btnEnd4_Click(object sender, EventArgs e)
    {
        Response.Redirect("myCart.aspx");
    }

    protected void btnEnd_Click(object sender, EventArgs e)
    {
        Response.Redirect("myCart.aspx");
    }

    protected void btnEnd5_Click(object sender, EventArgs e)
    {
        Response.Redirect("myCart.aspx");
    }

    protected void btnEnd3_Click(object sender, EventArgs e)
    {
        Response.Redirect("myCart.aspx");
    }

    protected void btnAdd1_Click(object sender, EventArgs e)
    {

    }
}