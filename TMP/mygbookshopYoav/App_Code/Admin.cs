using System;
// מרחב השמות בהם נמצאות המחלקות הטפלות בבסיס הנתונים בהן אנו נעזרים בשאילתות ממסד הנתונים
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Admin
/// </summary>
public class admin
{

    sqlDb sql = new sqlDb();
    //תכונות
    private string adminUser_Name; //שם משתמש
    private string adminPass; //סיסמה
    public admin()
    {

    }
    public admin(string aduser, string adpass)
    {
        this.adminUser_Name = aduser;
        this.adminPass = adpass;
    }
    public string AdminUser_Name
    {
        get { return this.adminUser_Name; }
        set { this.adminUser_Name = value; }

    }
    public string AdminPass
    {
        get { return this.adminPass; }
        set { this.adminPass = value; }

    }

}