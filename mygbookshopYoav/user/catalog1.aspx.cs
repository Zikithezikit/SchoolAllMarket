using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class user_catalog1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblSucc.Visible = false;
        pnlBook.Visible = false;

    }

    protected void btn_register_Click(object sender, EventArgs e)
    {
        Response.Redirect("loginuser.aspx");
    }

    protected void btn_loginadmin_Click(object sender, EventArgs e)
    {
        Response.Redirect("../admin/loginadmin.aspx");

    }





    protected void RadioButtonList1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        // הכנסת שמות הספרים לddl בזמן לחציה עליו
        DataSet dsBooks = new DataSet();
        books bk = new books();
        bk.BookType = RadioButtonList1.SelectedItem.Text;
        dsBooks = bk.bookByType(bk);
        dbl_books.Items.Clear();
        dbl_books.Items.Add("בחר ספר");
        string book;
        for (int i = 0; i < dsBooks.Tables[0].Rows.Count; i++)
        {
            book = dsBooks.Tables[0].Rows[i][1].ToString();
            dbl_books.Items.Add(book);
        }


    }

    protected void dbl_books_SelectedIndexChanged(object sender, EventArgs e)
    {
        ///אירוע המקבל את הפרטים של הספר מהפעולה bdt ממחלקת ספרים
        DataSet dsbook = new DataSet();
        books bk = new books();
        bk.BookName = dbl_books.SelectedItem.Text;
        dsbook = bk.bDT(bk);
        pnlBook.Visible = true;
        txtbookId.Text = dsbook.Tables[0].Rows[0][1].ToString();
        txtBookPrice.Text = dsbook.Tables[0].Rows[0][0].ToString();
        txt_book_price.Text = dsbook.Tables[0].Rows[0][2].ToString();
        Image1.ImageUrl = dsbook.Tables[0].Rows[0][3].ToString();
        txtTotal.Text = txt_book_price.Text;
        ddlAmount.Text = "1";
    }

    protected void ddlAmount_SelectedIndexChanged(object sender, EventArgs e)
    {
        // חישוב סך הכל לפי הכמות החדשה
        int price = int.Parse(txt_book_price.Text);
        int amount = int.Parse(ddlAmount.Text);
        int result = price * amount;
        txtTotal.Text = result.ToString()+ "₪";
        pnlBook.Visible = true;
    }

    protected void btnAdd_Click1(object sender, EventArgs e)
    {
        //בדיקה אם המשתמש התחבר או לא
        if (Session["user"] == null)
        {
            Response.Redirect("loginuser.aspx");
        }
        cart ctupd = new cart();
        ctupd.UserName = Session["user"].ToString();
        ctupd.BookId = txtbookId.Text;
        ctupd.OrderAmount = ddlAmount.SelectedItem.Text;
        ctupd.Total = txtTotal.Text;
        ctupd.addToCart(ctupd);
        lblSucc.Visible = true;
        pnlBook.Visible = true;
        grd_cart.DataSource = ctupd.getbooksforbuy(ctupd).Tables[0];
        grd_cart.DataBind();
        pnlBook.Visible = true;

    }

    protected void btnEnd_Click(object sender, EventArgs e)
    {
        Response.Redirect("myCart.aspx");
    }
}

