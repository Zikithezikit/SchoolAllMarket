using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for coupon
/// </summary>
public class coupon
{
    //תכונות
    string mainCoupon;
    string discCoupon;
    public coupon()
    {
        
    }
    public coupon (string mainCoupon,string discCoupon)
    {
        this.mainCoupon = mainCoupon;
        this.discCoupon = discCoupon;
    }
    public string MainCoupon
    {
        get { return this.mainCoupon; }
        set { this.mainCoupon = value; }
    }
    public string DiscCoupon
    {
        get { return this.discCoupon; }
        set { this.discCoupon = value; }
    }
}