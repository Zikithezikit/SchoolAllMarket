using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for fClub
/// </summary>
public class fClub
{
    //תכונות
    string id;
    string clubName;
   

    public fClub()
    {


       
    }
    public fClub(string id,string clubName)
    {
        this.id = id;
        this.clubName = clubName;
       
    }
    public string Id
    {
        get { return this.id; }
        set { this.id= value; }
    }
    public string ClubName
    {
        get { return this.clubName; }
        set { this.clubName = value; }
    }
   
}