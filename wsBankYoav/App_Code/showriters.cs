using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for showriters
/// </summary>
public class showriters
{

    //תכונות
    private string writerName;  // שם הכותב 
    private string bookName;//שם הספר
    private string cityname;//שם העיר
    private string placeName; //שם המקום
    private string showDate; //תאריך
    private string showTime; //שעה
    public showriters()
    {

    }

    public showriters(string writerName, string bookName, string cityname,string placeName,string showDate,string showTime)
    {
        this.writerName= writerName;
        this.bookName = bookName;
        this.cityname = cityname;
        this.placeName = placeName;
        this.showDate = showDate;
        this.showTime = showTime;
    }
    public string WriterName
    {
        get { return this.writerName; }
        set { this.writerName = value; }
    }
    public string Bookname
    {
        get { return this.bookName; }
        set { this.bookName = value; }
    }
    public string CityName
    {
        get { return this.cityname; }
        set { this.cityname = value; }
    }
    public string PlaceName
    {
        get { return this.placeName; }
        set { this.placeName = value; }
    }
    public string ShowTime
    {
        get { return this.showTime; }
        set { this.showTime=value; }
    }
    public string ShowDate
    {
        get { return this.showDate; }
        set { this.showDate= value; }
    }
}