using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_GridViewcatalog : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["booktype"] == null)
        {
            Response.Redirect("typeBookForGridviewcatalog.aspx");
        }
        else lbl_booktype.Text = Session["booktype"].ToString();
        
            books Getbooks = new books();
            Getbooks.BookType = Session["booktype"].ToString();
            grdBooks.DataSource = Getbooks.getBooksByType(Getbooks);
            grdBooks.DataBind();
        grdBooks.HeaderRow.Cells[5].Visible = false;
        for (int i = 0; i < grdBooks.Rows.Count; i++)
        {
            grdBooks.Rows[i].Cells[5].Visible = false;
        }

    }

    protected void txtBookPrice_TextChanged(object sender, EventArgs e)
    {

    }

    protected void grdBooks_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        // שליפת נתונים מהגריד וויו בהתאם לפנל בהתאם למספר השורה שבחרתי
        int row = Convert.ToInt32(e.CommandArgument);//בעזרת פקודה זו מקבלים את מספר השורה שבחרנו
        pnlBook.Visible = true;
        txtbookId.Text = grdBooks.Rows[row].Cells[2].Text;
        txtBookPrice.Text = grdBooks.Rows[row].Cells[3].Text;
        txt_book_price.Text = grdBooks.Rows[row].Cells[4].Text;
        txtTotal.Text = txt_book_price.Text;
        Image1.ImageUrl = grdBooks.Rows[row].Cells[1].Text;

        
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        cart ctupd = new cart();
        ctupd.UserName = Session["user"].ToString();
        ctupd.BookId = txtbookId.Text;
        ctupd.OrderAmount = ddlAmount.SelectedItem.Text;
        ctupd.Total = txtTotal.Text;
        ctupd.addToCart(ctupd);
        lblSucc.Visible = true;
        pnlBook.Visible = true;
        pnlBook.Visible = true;
    }

    protected void ddlAmount_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void txtTotal_TextChanged(object sender, EventArgs e)
    {

    }
}