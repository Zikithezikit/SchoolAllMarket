using System;
// מרחב השמות בהם נמצאות המחלקות הטפלות בבסיס הנתונים בהן אנו נעזרים בשאילתות ממסד הנתונים
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for orders
/// </summary>
public class orders
{

    //תכונות
    private string orderId;
    private string orderDate; //תאריך הזמנה
    private string username; //קוד לקוח
    sqlDb sql = new sqlDb();
    public orders(string ordate, string user)
    {
        this.orderDate = ordate;
        this.username = user;
    }
    public orders()
    {

    }

    public string OrderId
    {
        get { return this.orderId; }
        set { this.orderId = value; }

    }
    public string OrderDate
    {
        get { return this.orderDate; }
        set { this.orderDate = value; }

    }
    public string Username
    {
        get { return this.username; }
        set { this.username = value; }
    }
    ///שלב א) 
    //הכנסת תאריך הזמנה ושם משתמש לטבלת הזמנות 

    public void insertneworder(orders or)
    {
        string stinsert = "insert into tblOrders(orderDate,user_Name) values('"+or.OrderDate+"','"+or.Username+"')";
        sql.udi(stinsert);
    }
    //שליפת מספר ההזמנה האחרון של המשתמש שמזמין 

    public string getlastorderid (orders ord)
    {
        string stlastorderid = "SELECT Last(tblOrders.orderId) AS LastמתוךorderId FROM tblOrders GROUP BY tblOrders.user_Name HAVING(((tblOrders.user_Name) ='"+ord.Username+"'));";
        DataSet dslastorderid = new DataSet();
        dslastorderid = sql.chkData(stlastorderid);
        return dslastorderid.Tables[0].Rows[0][0].ToString();
    }
    //הכנסת מהסל לטבלת פרטי הזמנה המשמשת לנו כארכיון
    public  void insertNewSubOrder(string orderId, string bookId, string ammount ,string total)
    {
        sqlDb s = new sqlDb();
        string stInsert = "insert into tblSubOrders(orderId,bookId,orderAmount,total) value('" + int.Parse(orderId)+ "','" + int.Parse(bookId) + "','"+int.Parse(ammount)+"','" + int.Parse(total) + "')";
        s.udi(stInsert);
    }
    //מחיקה מהסל של הפריטים של המשתמש שביצע תשלום
    public void dellfromcart (orders user)
    {
        string stdell = "DELETE tblCart.user_Name FROM tblCart WHERE(((tblCart.user_Name) ='"+user.Username+"')); ";
        sql.udi(stdell);
    }
    public DataSet GetOrdersByName(string user)
    {
        string stGet = "SELECT tblOrders.orderDate, tblOrders.orderId FROM tblOrders WHERE(((tblOrders.user_Name) ='"+user+"'));";
        return sql.chkData(stGet);
    }
    public DataSet GetDetailsByOrderId(string OrderId)
    {
        string storder = "SELECT tblBooks.bookId, tblBooks.bookPrice, tblSubOrders.orderAmount, tblSubOrders.total FROM tblBooks INNER JOIN (tblOrders INNER JOIN tblSubOrders ON tblOrders.orderId = tblSubOrders.orderId) ON tblBooks.bookId = tblSubOrders.bookId WHERE(((tblOrders.orderId) ="+OrderId+"));";
        return sql.chkData(storder);
    }
}