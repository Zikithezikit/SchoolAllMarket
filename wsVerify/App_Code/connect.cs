using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for connect
/// </summary>
public class connect
{
    //שם הקובץ  של בסיס הנתונים  
    const string FILE_NAME = "VerifyData.mdb";

    // פעולה סטטית המחזירה מחרוזת התחברות.האתר יידע היכן קובץ  הנתונים נמצא ונוכל לעדכן ולבצע שאילתות על הנתונים  
    public static string GetConnectionString()
    {
          string location = HttpContext.Current.Server.MapPath("~/App_Data/" + FILE_NAME);
         string ConnectionString = @"provider=Microsoft.jet.oledb.4.0; data source =" + location;

        //string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|bookService.mdb";
        return ConnectionString;

    }
}