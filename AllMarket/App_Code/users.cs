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
        // TODO: Add constructor logic here (Nah)
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
        string loginst = "SELECT tbl_User.UserName, tbl_User.PassWord FROM tbl_User WHERE(((tbl_User.UserName) ='" + ul.User_Name + "') AND((tbl_User.PassWord) ='" + ul.Pass + "'));";
        dslogin = sql.chkData(loginst);
        if (dslogin.Tables[0].Rows.Count > 0) return true;
        else return false;
    }

    //בדיקה אם שם משתמש תפוס
    public bool ifExistes(users user)
    {
        DataSet dsuser = new DataSet();
        string stuser = "SELECT tbl_User.UserName FROM tbl_User WHERE(((tbl_User.UserName) ='" + user.User_Name + "'));";
        dsuser = sql.chkData(stuser);
        if (dsuser.Tables[0].Rows.Count > 0) return true;
        else return false;
    }
    // בודק אם אימייל קיים כבר
    public bool ifExistesEmail(users user)
    {
        DataSet dsuser = new DataSet();
        string stuser = "SELECT tbl_User.Email FROM tbl_User WHERE(((tbl_User.Email) ='" + user.Mail + "'));";
        dsuser = sql.chkData(stuser);
        if (dsuser.Tables[0].Rows.Count > 0) return true;
        else return false;
    }

    //הכנסת נתונים לטבלת משתמשים
    public void addUser(users newUser)
    {
        //[PassWord] - Because Password is a protected word in sql so if you want to use it you must use squered brakets [] :}
        string stAddUser = "insert into tbl_User(UserName,[PassWord],IsAdmin,Fname,Lname,Gender,Address,PhoneNumber,City,Email) values('" + newUser.User_Name + "','" + newUser.Pass + "','No','" + newUser.FName + "','" + newUser.LName + "','" + newUser.Gender + "','" + newUser.Addres + "','" + newUser.PhoneNumber + "','" + newUser.CityName + "','" + newUser.Mail + "')";
        sql.udi(stAddUser);
    }
    // פרטי משתמשים על פי עיר
    public DataSet userbycity(users uc)
    {
        string stUserCity = "SELECT tblCities.cityName, tblUsers.fName, tblUsers.lName, tblUsers.address, tblUsers.phoneNum FROM tblCities INNER JOIN tblUsers ON tblCities.cityId = tblUsers.cityName WHERE(((tblCities.cityName) = '" + uc.CityName + "'));";
        return sql.chkData(stUserCity);
    }
    //פרטי משתמשים לפי מגדר לפי מגדר
    public DataSet usersbygender(users ug)
    {
        string stUserGender = "SELECT tblGender.gender, tblUsers.phoneNum, tblUsers.fName, tblUsers.lName, tblUsers.address, tblUsers.cityName, tblUsers.email, tblUsers.user_Name, tblUsers.userPass FROM tblGender INNER JOIN tblUsers ON tblGender.genderId = tblUsers.gender WHERE(((tblGender.gender) = '" + ug.Gender + "'));";
        return sql.chkData(stUserGender);
    }
    //פרטי משתמש בהינתן שם משתמש
    public DataSet USERNAME(users UD)
    {
        string stuser = "SELECT tblUsers.user_Name, tblUsers.userId, tblUsers.fName, tblUsers.lName, tblUsers.address, tblUsers.cityName, tblUsers.gender, tblUsers.phoneNum, tblUsers.email FROM tblUsers WHERE(((tblUsers.user_Name) ='" + UD.User_Name + "')); ";
        return sql.chkData(stuser);
    }
    //מצא אם המשתמש הוא מנהל
    public bool Isadmin(string username)
    {
        DataSet dsuser = new DataSet();
        string stIsAdmin = "SELECT tbl_User.UserName, tbl_User.IsAdmin FROM tbl_User WHERE(((tbl_User.UserName) ='" + username + "'));";
        dsuser = sql.chkData(stIsAdmin);
        if (dsuser.Tables[0].Rows[0][1].ToString() == "Yes") return true;
        else return false;
    }

    //הנס שם משתמש וקבל ID
    public string GetIDByUserName(string name)
    {
        string stGet = "SELECT tbl_User.CustomerId, tbl_User.UserName FROM tbl_User WHERE(((tbl_User.UserName) ='"+name+"'));";
        return sql.chkData(stGet).Tables[0].Rows[0][0].ToString();
    }




    // סכום ההזמנות לפי שם משתמש
    public int GetAmountOfOrderByUserName(string username)
    {
        DataSet s = new DataSet();
        int amount;
        string stGet = "SELECT tblCart.user_Name, Sum(tblCart.orderAmount) AS SumמתוךorderAmount FROM tblCart GROUP BY tblCart.user_Name HAVING(((tblCart.user_Name) ='" + username + "'));";
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
    // השג שם משתמש על ידי id
    public string GetUsernameById(string id)
    {
        string stGet = "SELECT tbl_User.CustomerId, tbl_User.UserName FROM tbl_User WHERE(((tbl_User.CustomerId) ="+id.ToString()+"));";
        try
        {
            return sql.chkData(stGet).Tables[0].Rows[0][1].ToString();
        }
        catch
        {
            return "Something went wrong";
        }
    }
    // השג מספר טלפון על ידי שם משתמש
    public string GetPhoneNumberByUserName(string UsernameId)
    {
        string stGet = "SELECT tbl_User.UserName, tbl_User.PhoneNumber FROM tbl_User WHERE(((tbl_User.UserName) ='"+UsernameId+"'));";
        return sql.chkData(stGet).Tables[0].Rows[0][1].ToString();
    }

    // השג טבלת משתמשים לפי עיר
    public DataSet GetUsersByCity(string CityId)
    {
        string stGet = "SELECT tbl_User.CustomerId, tbl_User.UserName, tbl_User.PassWord, tbl_User.IsAdmin, tbl_User.Fname, tbl_User.Lname, tbl_gender.Genders, tbl_User.Address, tbl_User.PhoneNumber, tblCity.citys, tbl_User.Email FROM tbl_gender INNER JOIN (tblCity INNER JOIN tbl_User ON tblCity.CityId = tbl_User.City) ON tbl_gender.GenderID = tbl_User.Gender WHERE(((tblCity.citys) ='"+CityId+"'));";
        return sql.chkData(stGet);
    }

    // השג טבלת משתמשים ךפי מין
    public DataSet GetUserByGender(string GenderId)
    {
        string stGet = "SELECT tbl_User.CustomerId, tbl_User.UserName, tbl_User.PassWord, tbl_User.IsAdmin, tbl_User.Fname, tbl_User.Lname, tbl_gender.Genders, tbl_User.Address, tbl_User.PhoneNumber, tblCity.citys, tbl_User.Email FROM tbl_gender INNER JOIN (tblCity INNER JOIN tbl_User ON tblCity.CityId = tbl_User.City) ON tbl_gender.GenderID = tbl_User.Gender WHERE(((tbl_gender.Genders) ='"+GenderId+"'));";
        return sql.chkData(stGet);
    }

    // הכנס תגובה לטבלה
    public void addComment(string DateOfComment,string Comment, string Email)
    {
        string stAddComment = "insert into tbl_Comment(DateOfComment,Comment,Email) values('"+DateOfComment+"','"+Comment+"','"+Email+"')";
        sql.udi(stAddComment);
    }

    // כל פרטי המשתמש לפי משתמש
    public DataSet GetUserByUsername(string Username)
    {
        string stGet = "SELECT tbl_User.* FROM tbl_User WHERE(((tbl_User.UserName) ='"+Username+"'));";
        return sql.chkData(stGet);
    }

    //עדכן פרטי משתמש 
    public void UpdateUserInfo(users UpdateUser,string username)
    {
        string stUpdate = "UPDATE tbl_User SET tbl_User.UserName='" + UpdateUser.User_Name + "', tbl_User.PassWord='" + UpdateUser.Pass+ "',tbl_User.Fname='"+UpdateUser.FName+ "',tbl_User.Lname='"+UpdateUser.LName+ "',tbl_User.Gender='"+UpdateUser.Gender+ "',tbl_User.Address='"+UpdateUser.Addres+ "',tbl_User.PhoneNumber='"+UpdateUser.PhoneNumber+ "',tbl_User.City='"+UpdateUser.CityName+ "',tbl_User.Email='"+UpdateUser.Mail+ "' WHERE(tbl_User.UserName='"+username+"');";
        sql.udi(stUpdate);
    }
    // השג מספר משתמשים באתר
    public string GetNumberOfUsers()
    {
       string stget = "SELECT Count(tbl_User.UserName) AS CountמתוךUserName FROM tbl_User;";
        return sql.chkData(stget).Tables[0].Rows[0][0].ToString();
    }
    
}