using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for israeliBank
/// </summary>
public class israeliBank
{

    //תכונות
    private string currencyRate;
    private string currency;
    private string chgdate;

    public israeliBank()
    {
        
    }
    public israeliBank(string currencyRate, string currency,  string chgdate)
    {
        this.currencyRate = currencyRate;
        this.currency = currency;
        this.chgdate = chgdate;
    }
    public string CurrencyRate
    {
        get { return this.currencyRate; }
        set { this.currencyRate = value; }
    }
    public string Currency
    {
        get { return this.currency; }
        set { this.currency = value; }
    }
    public string Chgdate
    {
        get { return this.chgdate; }
        set { this.chgdate = value; }
    }
}
