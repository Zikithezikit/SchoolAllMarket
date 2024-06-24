using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{   
    //שם קובץ הנתונים והמקום בו נמצא   
    string connString = connect.GetConnectionString();
    public Service()
    {

       
    }
   
    //----------------כרטיס אשראי---------------
    // בדיקה אם כרטיס קיים פרמטרים מחלקה
    [WebMethod]
    public bool chkCard(string CreditNumber, string expMonth, string expYear, string Company, string CVVv, string IDDonator)
    {
        OleDbConnection conn = new OleDbConnection(connString);
        string sqlstr = "SELECT tblCredit.cardNum, tblCredit.exprMonth, tblCredit.experYear, tblCredit.company, tblCredit.cvv, tblCredit.id FROM tblCredit WHERE(((tblCredit.cardNum) ='" + CreditNumber + "') AND((tblCredit.exprMonth) ='" + expMonth + "') AND((tblCredit.experYear) ='" + expYear + "') AND((tblCredit.company) ='" + Company + "') AND((tblCredit.cvv) ='" + CVVv + "') AND(tblCredit.id) = '"+IDDonator+"');";
        OleDbDataAdapter da = new OleDbDataAdapter(sqlstr, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
            return true;
        else return false;

    }
  
    // החזרת פרטי משתמש מחברת האשראי ע"פ ת"ז
    [WebMethod]
    public DataSet chkInfo(String ThisId)
    {
       
        OleDbConnection conn = new OleDbConnection(connString);
        string sqlstr = "SELECT tblCredit.id, tblCredit.cardNum, tblCredit.exprMonth, tblCredit.company, tblCredit.cvv, tblCredit.fName, tblCredit.lName, tblCredit.adress, tblCredit.city, tblCredit.experYear FROM tblCredit WHERE(((tblCredit.id) ='"+ThisId+"'));";
        OleDbDataAdapter da = new OleDbDataAdapter(sqlstr, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }

    //----------------------------------------------מתנות למשתמש--------------------------------
    [WebMethod]
    public DataSet getGift()
    {

        OleDbConnection conn = new OleDbConnection(connString);

        string sqlstr = "SELECT tblGifts.giftName, tblGifts.giftImg FROM tblGifts; ";
        OleDbDataAdapter da = new OleDbDataAdapter(sqlstr, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }

    // ------------------------- פעולות בנק ישראל------------------------
    // הצגת שערי מטבע
    [WebMethod]
    public DataSet GetAllCurrencyRates()
    {
        
        OleDbConnection conn = new OleDbConnection(connString);

        string sqlstr = "SELECT tblIsraelBank.currencyRate, tblIsraelBank.currency FROM tblIsraelBank;";
        OleDbDataAdapter da = new OleDbDataAdapter(sqlstr, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }

    //פעולה המקבלת סוג מטבע וסכום בשקלים וממירה בהתאם
    [WebMethod]
    public double getTotal (israeliBank ilbank,string totalShekel)
    {

        OleDbConnection conn = new OleDbConnection(connString);
        string sqlstr = "SELECT tblIsraelBank.currency, tblIsraelBank.currencyRate FROM tblIsraelBank WHERE(((tblIsraelBank.currency) ='"+ilbank.Currency+"'));   ";
        OleDbDataAdapter da = new OleDbDataAdapter(sqlstr, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        string rate1 = ds.Tables[0].Rows[0][1].ToString();
        return double.Parse(totalShekel) / double.Parse(rate1);

    }
    // עדכון שער חדש בד"כ שינוי באותו היום
    [WebMethod]
    public void updRate(israeliBank show)
    {

        OleDbConnection conn = new OleDbConnection(connString);
        string sqlstr = "UPDATE tblIsraelBank SET tblIsraelBank.currencyRate ='"+show.CurrencyRate+"' WHERE(((tblIsraelBank.currency) ='"+show.Currency+"')); ";
        OleDbCommand build = new OleDbCommand(sqlstr, conn);
        conn.Open();
        build.ExecuteNonQuery();
        conn.Close();
    }
    // הכנסת שער חדש למטבע
    [WebMethod]
    public void InsertCurrencyRate(israeliBank add)
    {

        OleDbConnection conn = new OleDbConnection(connString);
        string sqlstr = "insert into tblIsraelBank (currencyRate,[currency],chgdate)values('" + add.CurrencyRate+"','"+add.Currency+"','"+add.Chgdate+"' ) ";
        OleDbCommand build = new OleDbCommand(sqlstr, conn);
        conn.Open();
        build.ExecuteNonQuery();
        conn.Close();
    }
    // מחיקת מטבע מבנק ישראל
    [WebMethod]
    public void DeleteCurrency(israeliBank del)
    {

        OleDbConnection conn = new OleDbConnection(connString);
        string sqlstr = "DELETE tblIsraelBank.currency FROM tblIsraelBank WHERE(((tblIsraelBank.currency) ='"+del.Currency+"'));";
        OleDbCommand build = new OleDbCommand(sqlstr, conn);
        conn.Open();
        build.ExecuteNonQuery();
        conn.Close();
    }

  
    //--------------- פעולות קופונים---------------
    //  הצגת קופונים למנהל
    [WebMethod]
    public DataSet GetAllcoupon()
    {

        OleDbConnection conn = new OleDbConnection(connString);

        string sqlstr = "SELECT tblCoupon.mainCoupon, tblCoupon.discCoupon FROM tblCoupon;";
        OleDbDataAdapter da = new OleDbDataAdapter(sqlstr, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }
    // הכנסת שער קופון חדש ע"י מנהל
    [WebMethod]
    public void InsertNewCoupon(coupon add)
    {

        OleDbConnection conn = new OleDbConnection(connString);
        string sqlstr = "insert into tblCoupon (mainCoupon,discCoupon)values('" + add.MainCoupon + "','" + add.DiscCoupon + "') ";
        OleDbCommand build = new OleDbCommand(sqlstr, conn);
        conn.Open();
        build.ExecuteNonQuery();
        conn.Close();
    }
    // מחיקת קופון לאחר שימוש בקופון
    [WebMethod]
    public void DeleteCoupon(coupon del)
    {

        OleDbConnection conn = new OleDbConnection(connString);
        string sqlstr = "DELETE tblCoupon.mainCoupon FROM tblCoupon WHERE(((tblCoupon.mainCoupon) ='"+del.MainCoupon+"'));";
        OleDbCommand build = new OleDbCommand(sqlstr, conn);
        conn.Open();
        build.ExecuteNonQuery();
        conn.Close();
    }
    // עדכון קופון ע"י מנהל 
    [WebMethod]
    public void updCoupon(coupon updCoupon)
    {

        OleDbConnection conn = new OleDbConnection(connString);
        string sqlstr = "UPDATE tblCoupon SET tblCoupon.discCoupon = '"+updCoupon.DiscCoupon+"' WHERE(((tblCoupon.mainCoupon) ='"+updCoupon.MainCoupon+"'));";
        OleDbCommand build = new OleDbCommand(sqlstr, conn);
        conn.Open();
        build.ExecuteNonQuery();
        conn.Close();
    }
    //בדיקה אם קופון קיים
    [WebMethod]
    public bool chkCoupon(coupon ck)
    {
        OleDbConnection conn = new OleDbConnection(connString);
        string sqlstr = "SELECT tblCoupon.mainCoupon FROM tblCoupon WHERE(((tblCoupon.mainCoupon) ='"+ck.MainCoupon+"'));";
        OleDbDataAdapter da = new OleDbDataAdapter(sqlstr, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
            return true;
        else return false;

    }
    //===================פעולות על לחברי מועדון===========
    // בדיקה אם חבר מועדון-פרמטר אובייקט
    [WebMethod]
    public DataSet chkFclub(fClub chk)
    {

        OleDbConnection conn = new OleDbConnection(connString);
        string sqlstr = "SELECT tblClub.clubName, tblClub.discClub FROM tblClub WHERE(((tblClub.id) ='" + chk.Id + "'));";
        OleDbDataAdapter da = new OleDbDataAdapter(sqlstr, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }
    // הכנסת  חבר מועדון חדש ע"י מנהל
    [WebMethod]
    public void InsertNewClub(fClub add)
    {

        OleDbConnection conn = new OleDbConnection(connString);
        string sqlstr = "insert into tblClub (id,clubName)values('" + add.Id + "','" + add.ClubName + "') ";
        OleDbCommand build = new OleDbCommand(sqlstr, conn);
        conn.Open();
        build.ExecuteNonQuery();
        conn.Close();
    }
    // מחיקת חבר מועדון 
    [WebMethod]
    public void DeleteMember(fClub del)
    {

        OleDbConnection conn = new OleDbConnection(connString);
        string sqlstr = "DELETE tblClub.id FROM tblClub WHERE(((tblClub.id) ='"+del.Id+"')); ";
        OleDbCommand build = new OleDbCommand(sqlstr, conn);
        conn.Open();
        build.ExecuteNonQuery();
        conn.Close();
    }

}