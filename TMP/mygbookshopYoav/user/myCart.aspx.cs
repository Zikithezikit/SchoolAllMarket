using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_myCart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Redirect("loginuser.aspx");
        }
        pnlcradit.Visible = false;
        btnrecupt.Visible = false;
        lblsucc.Visible = false;
        txtDate.Text = DateTime.Now.ToString();
        cart mycart = new cart();
        mycart.UserName = Session["user"].ToString();
        ///הצגת פרטי משתמש על פי שם משתמש אליו ישלחו הפרטים לאחר ביצוע תשלום
        grduser.DataSource = mycart.getuser(mycart);
        grduser.DataBind();
        ///הצגת סל הקניות למשתמש 
        grdbook.DataSource = mycart.getbooksforbuy(mycart);
        grdbook.DataBind();
        int sum = 0;
        if(grdbook.Rows.Count>0)
        {
            for(int i=0;i<grdbook.Rows.Count;i++)
            {
                ///שליפת נתונים מתוך גרידויו
                sum+= int.Parse(grdbook.Rows[i].Cells[5].Text);
            }
            txttotal.Text = sum.ToString();
            txtnum.Text = grdbook.Rows.Count.ToString();
        } 
    }

    protected void bynrecipt_Click(object sender, EventArgs e)
    {
        Response.Redirect("recipt.aspx");

    }

    protected void btnpnl_Click(object sender, EventArgs e)
    {
        
    }

    protected void txtDate_TextChanged(object sender, EventArgs e)
    {

    }

    protected void grdbook_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void grdbook_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        //מחיקה מהסל. כדי למחוק מהסל אנו חייבים לדעת קודם באיזה שורה בחרנו למחוק .
        int row = e.RowIndex;//נותן לנו את מספר השורה שבחרנו למחיקה
        string bookid = grdbook.Rows[row].Cells[1].Text; 

        cart bookdelet=new cart();
        bookdelet.UserName = Session["user"].ToString();
        bookdelet.BookId = bookid;
        bookdelet.deletecartrow(bookdelet);
        Response.Redirect("myCart.aspx");
    }

    protected void btnpay_Click(object sender, EventArgs e)
    {
        Session["card"] = txtcardnum.Text;
        ///סיום הזמנה
        ///לסיום ההזמנה יש שלושה שלבים
        /// שלב א) הכנסת תאריך ההזמנה ושם המשתמש שמבצע את הקנייה ואוטומטית מתקבל על ידי המערכת מספר ההזמנה שלו כמו כן לאחר קבלת מספר ההזמנה ולמעשה זה יהיה מספר ההזמנה האחרון של ותו שם משתמש באנחה שביצע כבר מספר הזמנות 
        ///שנעתיק מטבלת הסל את הפרטים שהמשתמש קנה ונשים אותם בטבלת פירטי ההזמנה שהיא טבלה שמשמשת אותנו כארכיון שלב ב
        ///לאחר 2 השלבים נמחק מהסל את הפריטים שהמשתמש קנה ושעוברו לארכיון
        orders endorder = new orders();
        endorder.OrderDate = txtDate.Text;
        endorder.Username = Session["user"].ToString();
        endorder.insertneworder(endorder);
        //שמירת מספר ההזמנה האחרון של המשתמש שמזמין
        Session["orderid"] = endorder.getlastorderid(endorder);
        //הכנסה לטבלת פרטי ההזמנה מהסל שורה שורה עם לולאה בעזרת הפעולה שכתבנו במחלקת ORDERS
        string orderId= "", bookId = "", ammount = "", total = "";
        for (int i = 0; i < grdbook.Rows.Count; i++)
        {
            bookId = grdbook.Rows[i].Cells[1].Text;
            ammount = grdbook.Rows[i].Cells[4].Text;
            total = grdbook.Rows[i].Cells[5].Text;
            endorder.insertNewSubOrder(Session["orderid"].ToString(),bookId,ammount,total);
        }
        //שלב ג 
        // לאחר ביצוע העברת הנתונים מהסל לטבלת פרטי ההזמנה המשמשת לנו כארכיון וביצוע יש למחוק מהסל למשתמש הנוכחי את הפרטים 
        endorder.dellfromcart(endorder);
        lblsucc.Visible = true;
        btnrecupt.Visible = true;
        
    }
}