using System;
// מרחב השמות בהם נמצאות המחלקות הטפלות בבסיס הנתונים בהן אנו נעזרים בשאילתות ממסד הנתונים
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for users
/// </summary>
public class users
{
    // הגדרת אובייקט\מצביע למחלקה SQLDנ על מנת להשתמש בפעולות chkData ו udi
    sqlDb sql = new sqlDb();

    //תכונות
    private string fName;  // שם פרטי
    private string lName;//שם משפחה
    private string addres;//כתובת
    private string cityName; //עיר
    private string gender; //מגדר
    private string phoneNumber; //טלפון
    private string mail; //דואר אלקטרוני
    private string user_Name; //שם משתמש
    private string pass; //סיסמה

    public users()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public users(string fN, string lN, string aD, string cN, string gE, string pN, string mA, string uN, string pA)
    {
        this.fName = fN;
        this.lName = lN;
        this.addres = aD;
        this.cityName = cN;
        this.gender = gE;
        this.phoneNumber = pN;
        this.mail = mA;
        this.user_Name = uN;
        this.pass = pA;

    }
    public string FName
    {
        get { return this.fName; }
        set { this.fName = value; }
    }
    public string LName
    {
        get { return this.lName; }
        set { this.lName = value; }
    }
    public string Addres
    {
        get { return this.addres; }
        set { this.addres = value; }
    }
    public string CityName
    {
        get { return this.cityName; }
        set { this.cityName = value; }

    }
    public string Gender
    {
        get { return this.gender; }
        set { this.gender = value; }

    }
    public string PhoneNumber
    {
        get { return this.phoneNumber; }
        set { this.phoneNumber = value; }

    }
    public string Mail
    {
        get { return this.mail; }
        set { this.mail = value; }

    }
    public string User_Name
    {
        get { return this.user_Name; }
        set { this.user_Name = value; }

    }
    public string Pass
    {
        get { return this.pass; }
        set { this.pass = value; }

    }
    //התחברות משתמש
    public bool loginuser(users ul)
    {
        DataSet dslogin = new DataSet();
        string loginst = "SELECT tblUsers.user_Name, tblUsers.userPass FROM tblUsers WHERE(((tblUsers.user_Name) ='"+ul.User_Name+"') AND ((tblUsers.userPass) ='"+ul.Pass+"'));";
        dslogin = sql.chkData(loginst);
        if (dslogin.Tables[0].Rows.Count > 0) return true;
        else return false;
    }
    // התחברות אדמין
    public bool loginAdmin(users ul)
    {
        DataSet dslogin = new DataSet();
        string stlogin = "SELECT tblAdmin.adminUser, tblAdmin.adminPass FROM tblAdmin WHERE(((tblAdmin.adminUser) ='"+ul.user_Name+"') AND((tblAdmin.adminPass) ='"+ul.Pass+"'))";
        dslogin = sql.chkData(stlogin);
        if (dslogin.Tables[0].Rows.Count > 0) return true;
        else return false;
    }

    //בדיקה אם שם משתמש תפוס
    public bool ifExistes(users user)
    {
        DataSet dsuser = new DataSet();
        string stuser = "SELECT tblUsers.user_Name FROM tblUsers WHERE(((tblUsers.user_Name) ='" + user.user_Name + "'))";
        dsuser = sql.chkData(stuser);
        if (dsuser.Tables[0].Rows.Count > 0) return true;
        else return false;
    }

    //הכנסת נתונים לטבלת משתמשים
    public void addUser(users newUser)
    {
        string stAddUser = "insert into tblUsers(fName,lName,address,cityName,gender,phoneNum,email,user_Name,userPass) values('"+newUser.FName+ "','" + newUser.LName+ "','" + newUser.Addres+ "','" + newUser.CityName+ "','" + newUser.Gender+ "','" + newUser.PhoneNumber+ "','" + newUser.Mail+ "','" + newUser.User_Name+ "','" + newUser.Pass+ "')";
        sql.udi(stAddUser);
    }
    // פרטי משתמשים על פי עיר
    public DataSet userbycity(users uc)
    {
        string stUserCity = "SELECT tblCities.cityName, tblUsers.fName, tblUsers.lName, tblUsers.address, tblUsers.phoneNum FROM tblCities INNER JOIN tblUsers ON tblCities.cityId = tblUsers.cityName WHERE(((tblCities.cityName) = '"+uc.CityName+"'));";
        return sql.chkData(stUserCity);
    }
    //פרטי משתמשים לפי מגדר לפי מגדר
    public DataSet usersbygender(users ug)
    {
        string stUserGender = "SELECT tblGender.gender, tblUsers.phoneNum, tblUsers.fName, tblUsers.lName, tblUsers.address, tblUsers.cityName, tblUsers.email, tblUsers.user_Name, tblUsers.userPass FROM tblGender INNER JOIN tblUsers ON tblGender.genderId = tblUsers.gender WHERE(((tblGender.gender) = '"+ug.Gender+"'));";
        return sql.chkData(stUserGender);
    }
    //פרטי משתמש בהינתן שם משתמש
    public DataSet USERNAME(users UD)
    {
        string stuser = "SELECT tblUsers.user_Name, tblUsers.userId, tblUsers.fName, tblUsers.lName, tblUsers.address, tblUsers.cityName, tblUsers.gender, tblUsers.phoneNum, tblUsers.email FROM tblUsers WHERE(((tblUsers.user_Name) ='"+UD.User_Name +"')); ";
        return sql.chkData(stuser);
    }

    // סכום ההזמנות לפי שם משתמש
    public int GetAmountOfOrderByUserName(string username)
    {
        DataSet s = new DataSet();
        int amount;
        string stGet = "SELECT tblCart.user_Name, Sum(tblCart.orderAmount) AS SumמתוךorderAmount FROM tblCart GROUP BY tblCart.user_Name HAVING(((tblCart.user_Name) ='"+username+"'));";
        try
        {
            s = sql.chkData(stGet);
        }
        catch
        {
            return 0;
        }
        if (s.Tables[0].Rows.Count > 0)
            amount = int.Parse(s.Tables[0].Rows[0][1].ToString());
        else amount = 0; 
        return amount;
    }
}