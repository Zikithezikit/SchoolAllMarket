using System;
// מרחב השמות בהם נמצאות המחלקות הטפלות בבסיס הנתונים בהן אנו נעזרים בשאילתות ממסד הנתונים
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CreditCardDonation
/// </summary>
public class CreditCardDonation
{
    // הגדרת אובייקט\מצביע למחלקה SQLDנ על מנת להשתמש בפעולות chkData ו udi
    sqlDb sql = new sqlDb();
    public CreditCardDonation()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public void InsertNewDonation(string Date,string amount,string DonorId)
    {
        string stinsert = "insert into tbl_Donation(DateoOfDonation,AmountDonated,DonorID) values('" + Date+"','"+amount+"','"+DonorId+"')";
        sql.udi(stinsert);
    }
    public DataSet GetReceiptsFromDonorID(string DonorID)
    {
        string stGet = "SELECT tbl_Donation.DonorID, tbl_Donation.id, tbl_Donation.DateoOfDonation, tbl_Donation.AmountDonated FROM tbl_Donation WHERE(((tbl_Donation.DonorID) ='"+DonorID+ "')) ORDER BY tbl_Donation.id DESC;";
        DataSet Ne = new DataSet();
        Ne = sql.chkData(stGet);
        return Ne;
    }
}