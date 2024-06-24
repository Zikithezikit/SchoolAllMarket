using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for gift
/// </summary>
public class gift
{
    public gift()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    //תכונות
    string giftName;
    string giftImg;


   
    public gift(string giftName, string giftImg)
    {
        this.giftName = giftName;
        this.giftImg = giftImg;

    }
    public string GiftName
    {
        get { return this.giftName; }
        set { this.giftName = value; }
    }
    public string GiftImg
    {
        get { return this.giftImg; }
        set { this.giftImg = value; }
    }
}