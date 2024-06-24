using System;
// מרחב השמות בהם נמצאות המחלקות הטפלות בבסיס הנתונים בהן אנו נעזרים בשאילתות ממסד הנתונים
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for cart
/// </summary>
public class cart
{
    public cart()
    {

    }
    sqlDb sql = new sqlDb();
    //תכונות 
    string userName;
    string bookId;
    string orderAmount;
    string total;

    //public cart(string user,string bid,string ordamount,string tot)
    //{
    //    this.userName = user;
    //    this.bookId = bid;
    //    this.orderAmount = ordamount;
    //    this.total = tot;
    //}

    public string UserName
    {
        get { return this.userName; }
        set { this.userName = value; }
    }
    public string BookId
    {
        get { return this.bookId; }
        set { this.bookId = value; }
    }
    public string OrderAmount
    {
        get { return this.orderAmount; }
        set { this.orderAmount = value; }
    }
    public string Total
    {
        get { return this.total; }
        set { this.total = value; }
    }
    // הוספה לסל ראשית בדיקה אם הספר קיים בסל אם לא מבצעים הכנסה רגילה ואם הוא קיים מבצעים שאילתת עדכון כולל חישוב כמות וסך הכל
    public void addToCart(cart ct)
    {
        DataSet ds = new DataSet();
        string ifExsit = "SELECT tblCart.user_Name, tblCart.bookId, tblCart.orderAmount, tblCart.total FROM tblCart WHERE(((tblCart.user_Name) = '"+ct.UserName+"') AND((tblCart.bookId) ="+ct.BookId+"));";
        ds = sql.chkData(ifExsit);
        int newAmount, NewTOT;
        if (ds.Tables[0].Rows.Count > 0)
        {
            newAmount = int.Parse(ct.OrderAmount) + int.Parse(ds.Tables[0].Rows[0][2].ToString());
            NewTOT = newAmount * ((int.Parse(ds.Tables[0].Rows[0][3].ToString()) / (int.Parse(ds.Tables[0].Rows[0][2].ToString()))));
            string stupd = "UPDATE tblCart SET tblCart.orderAmount = '"+newAmount+"' , tblCart.total = '"+NewTOT+"' WHERE(((tblCart.user_Name) = '"+ct.UserName+"') AND((tblCart.bookId) ="+ct.BookId+"));";
            sql.udi(stupd);
        }
        else
        {
            string stadd = "INSERT INTO tblCart(user_Name,bookId,orderAmount,total) values('"+ct.userName+ "','"+ct.BookId+"','"+ct.OrderAmount+"','"+ct.Total+"')";
            sql.udi(stadd);
        }
    }
    public DataSet getuser (cart user) ///פעולה המחזירה פרטי משתמש על פי שם משתמש
    {
        string stuser= "SELECT tblUsers.fName, tblUsers.lName, tblUsers.address, tblCities.cityName FROM tblCities INNER JOIN tblUsers ON tblCities.cityId = tblUsers.cityName WHERE(((tblUsers.user_Name) ='"+user.UserName+"')); ";
        return sql.chkData(stuser);
    }
    
    public DataSet getbooksforbuy(cart user) ///פעולה המחזירה את של הקניות של משתמש מסוים
    {
        string stuser = "SELECT tblCart.bookId, tblBooks.bookName, tblBooks.bookPrice, tblCart.orderAmount, tblCart.total FROM tblBooks INNER JOIN tblCart ON tblBooks.bookId = tblCart.bookId WHERE(((tblCart.user_Name) ='"+user.UserName+"')); ";
        return sql.chkData(stuser);
    }
    public void deletecartrow (cart dl) //מחיקת שורה מהסל
    {
        string dlbook = "DELETE tblCart.user_Name, tblCart.bookId FROM tblCart WHERE(((tblCart.user_Name) ='"+dl.UserName+"') AND((tblCart.bookId) ="+dl.BookId+"));";
         sql.udi(dlbook);

    }
}