using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for credit
/// </summary>
public class Credit
{
    //תכונות
    private string id;  // תז
    private string cardNum;//מס כרטיס
    private string expr;//תוקף
    private string company; //חברה
    private string cvv; //3 ספרות גב כרטיס
    private string fName; //שם פרטי
    private string lName; //שם משפחה
    private string adress; //כתובת
    private string city; //עיר

    public Credit()
    {
        
    }
    public Credit(string id, string cardNum, string expr, string company, string cvv, string fName, string lName, string adress, string city)
    {
        this.id = id;
        this.cardNum = cardNum;
        this.expr = expr;
        this.company = company;
        this.cvv = cvv;
        this.fName = fName;
        this.lName = lName;
        this.adress = adress;
        this.city = city;
        
    }
    public string Id
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public string CardNum
    {
        get { return this.cardNum; }
        set { this.cardNum = value; }
    }
    public string Expr
    {
        get { return this.expr; }
        set { this.expr = value; }
    }
    public string Company
    {
        get { return this.company; }
        set { this.company = value; }
    }
    public string Cvv
    {
        get { return this.cvv; }
        set { this.cvv = value; }
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
    public string Adress
    {
        get { return this.adress; }
        set { this.adress = value; }
    }
    public string City
    {
        get { return this.city; }
        set { this.city= value; }
    }
}