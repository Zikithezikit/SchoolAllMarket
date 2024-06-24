using System;
// מרחב השמות בהם נמצאות המחלקות הטפלות בבסיס הנתונים בהן אנו נעזרים בשאילתות ממסד הנתונים
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for books
/// </summary>
public class books
{
    sqlDb sql = new sqlDb();
    //תכונות
    private string bookId;
    private string bookName;  // שם ספר
    private string bookPrice;//מחיר ספר
    private string bookType;//סוג הספר
    private string bookImg; //תמונה של הספר

    public books()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public books(string bId, string bname, string bprice, string btype, string bimg)
    {
        this.bookId = bId;
        this.bookName = bname;
        this.bookPrice = bprice;
        this.bookType = btype;
        this.bookImg = bimg;
    }
    public string BookId
    {
        get { return this.bookId; }
        set { this.bookId = value; }
    }
    public string BookName
    {
        get { return this.bookName; }
        set { this.bookName = value; }
    }
    public string BookPrice
    {
        get { return this.bookPrice; }
        set { this.bookPrice = value; }
    }
    public string BookType
    {
        get { return this.bookType; }
        set { this.bookType = value; }
    }
    public string BookImg
    {
        get { return this.bookImg; }
        set { this.bookImg = value; }
    }
    //מחזירה את שמות הספרים לפי סוג
    public DataSet bookByType(books bt)
    {
        DataSet dsBooks = new DataSet();
        string stBook = "SELECT tblBookType.TypeName, tblBooks.bookName, tblBooks.bookPrice, tblBooks.bookType FROM tblBookType INNER JOIN tblBooks ON tblBookType.typeId = tblBooks.bookType WHERE(((tblBookType.TypeName) = '" + bt.BookType + "'));";
        dsBooks = sql.chkData(stBook);
        return dsBooks;
    }
    // פעולה המחזירה את םרטי הספר על פי שמו
    public DataSet bDT(books bk)
    {
        string StBook = "SELECT tblBooks.bookName, tblBooks.bookId, tblBooks.bookPrice, tblBooks.bookImg FROM tblBooks WHERE(((tblBooks.bookName) ='" + bk.BookName + "'));";
        return sql.chkData(StBook);
    }
    //הפעולה מחזירה את פרטי הספרים בהתאם לסוג הספר עבור גקריד וויו קטלוג
    public DataSet getBooksByType(books gbt)
    {
        string stbooks = "SELECT tblBooks.bookId, tblBooks.bookName, tblBooks.bookPrice, tblBooks.bookImg FROM tblBookType INNER JOIN tblBooks ON tblBookType.typeId = tblBooks.bookType WHERE(((tblBookType.typeName) ='"+gbt.BookType+"'));";
        return sql.chkData(stbooks);
    }
    //פעולה המחזירה את קוד הספר שם הספר מחיר הספק ותמונה בהתאם לסוג הספר עבור Panel Catalog
    public DataSet getBooks(books bk)
    {
        string stbook = "SELECT tblBooks.bookId, tblBooks.bookName, tblBooks.bookPrice, tblBooks.bookImg FROM tblBookType INNER JOIN tblBooks ON tblBookType.typeId = tblBooks.bookType WHERE(((tblBookType.typeName) ='"+bk.BookType+"')); ";
        return sql.chkData(stbook);
    }
}
