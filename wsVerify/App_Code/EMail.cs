using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for EMail
/// </summary>
public class EMail
{
    public EMail()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public bool IsExists(string Email)
    {
        string st = "SELECT Email.Email FROM Email WHERE(((Email.Email) ='"+Email+"'));";
        sqlDb sql = new sqlDb();
        return(sql.chkData(st).Tables[0].Rows.Count>0);

    }
}