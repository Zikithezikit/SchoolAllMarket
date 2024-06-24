using System;
// מרחב השמות בהם נמצאות המחלקות הטפלות בבסיס הנתונים בהן אנו נעזרים בשאילתות ממסד הנתונים
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Products
/// </summary>
public class Products
{
    // הגדרת אובייקט\מצביע למחלקה SQLDנ על מנת להשתמש בפעולות chkData ו udi
    sqlDb sql = new sqlDb();

    private string Title; // כותרת
    private string SellerName; // שם המוכר
    private string DateOfUpload; // תאריך העלאה 
    private string Category; // קטגוריה
    private string Subcategory; // סב קטגוריה
    private string WillingToTrade; // מוכן להחליף
    private string Img; // תמונה
    private string Condition; // מצב שימוש
    private string Price; // מחיר
    private string Description;


    public Products()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string title
    {
        get { return this.Title; }
        set { this.Title = value; }
    }
    public string sellerName
    {
        get { return this.SellerName; }
        set { this.SellerName = value; }
    }
    public string dateOfUpload
    {
        get { return this.DateOfUpload; }
        set { this.DateOfUpload = value; }
    }
    public string category
    {
        get { return this.Category; }
        set { this.Category = value; }
    }
    public string subcategory
    {
        get { return this.Subcategory; }
        set { this.Subcategory = value; }
    }
    public string willingToTrade
    {
        get { return this.WillingToTrade; }
        set { this.WillingToTrade = value; }
    }
    public string img
    {
        get { return this.Img; }
        set { this.Img = value; }
    }
    public string condition
    {
        get { return this.Condition; }
        set { this.Condition = value; }
    }
    public string price
    {
        get { return this.Price; }
        set { this.Price = value; }
    }
    public string description
    {
        get { return this.Description; }
        set { this.Description = value; }
    }
    public DataSet AllProducts(Products P)
    {
        string str_products = "SELECT tbl_Products.* FROM tbl_Products;";
        DataSet dsproducts = new DataSet();
        dsproducts = sql.chkData(str_products);
        return dsproducts;
    }
    public DataSet FilterProducts(string Category, string Condition)
    {
        string str_products = "SELECT tbl_Products.ProductId, tbl_Products.Title, tbl_Products.SellerName, tbl_Products.DateOfUpload, tbl_Products.Category, tbl_Products.Subcategory, tbl_Products.WillingToTrade, tbl_Products.Img, tbl_Products.Condition, tbl_Products.Price, tbl_Products.Description FROM tbl_Products WHERE(((tbl_Products.Category) ="+ Category + ") AND((tbl_Products.Condition) ="+ Condition + "));";
        DataSet dsproducts = new DataSet();
        dsproducts = sql.chkData(str_products);
        return dsproducts;
    }
    public string GetConditionById(string id)
    {
        string stGet = "SELECT tbl_Condition.ConditionId, tbl_Condition.ConditionName FROM tbl_Condition WHERE(((tbl_Condition.ConditionId) ="+id+"));";
        return sql.chkData(stGet).Tables[0].Rows[0][1].ToString();
    }
    //תשיג קטגוריה לפי ID
    public string GetCategoryById(string id)
    {
        string stGet = "SELECT tbl_Category.CategoryId, tbl_Category.CategoryName FROM tbl_Category WHERE(((tbl_Category.CategoryId) ="+id+"));";
        return sql.chkData(stGet).Tables[0].Rows[0][1].ToString();
    }
    //הכנס מוצר חדש לטבלה
    public void addProduct(Products NewProduct)
    {
        //  F11
        string stInsert = "insert into tbl_Products(Title,SellerName,DateOfUpload,Category,Subcategory,WillingToTrade,Img,Condition,Price,Description) values('"+NewProduct.title+"','"+NewProduct.sellerName+"','"+NewProduct.dateOfUpload+"','"+NewProduct.category+"','0','No','"+NewProduct.img+"','"+NewProduct.condition+"','"+NewProduct.price+"','"+NewProduct.description+"')";
        sql.udi(stInsert);
    }
    public void AddToFavorite(string idFavorite, string username)
    {
        string stAddFavorite = "insert into tbl_FavoriteProducts(ProductID,UserName) values('" + idFavorite + "','" + username + "')";
        sql.udi(stAddFavorite);
        //הוסף את המוצר לסל ולקרוא לו ב TrasferValue.aspx.cs
    }
    //השג מוצרים מועדפים לפי שם משתמש
    public DataSet GetFavotiteProductsOfUserByUserName(string username)
    {
        string stGet = "SELECT tbl_FavoriteProducts.UserName, tbl_Products.ProductId, tbl_Products.Title, tbl_Products.SellerName, tbl_Products.DateOfUpload, tbl_Products.Category, tbl_Products.Subcategory, tbl_Products.WillingToTrade, tbl_Products.Img, tbl_Products.Condition, tbl_Products.Price, tbl_Products.Description FROM tbl_Products INNER JOIN tbl_FavoriteProducts ON tbl_Products.ProductId = tbl_FavoriteProducts.ProductID WHERE(((tbl_FavoriteProducts.UserName) ='" + username + "'));";
        return sql.chkData(stGet);
    }
    //בודק אם המוצר נמצא ברשימת המועדפים של המשתמש
    public bool IsFavoriteProductsExists(string username ,string FavoriteId)
    {
        string stGet = "SELECT tbl_FavoriteProducts.UserName, tbl_FavoriteProducts.ProductID FROM tbl_FavoriteProducts WHERE(((tbl_FavoriteProducts.UserName) ='"+username+"') AND((tbl_FavoriteProducts.ProductID) ="+FavoriteId+"));";
        return sql.chkData(stGet).Tables[0].Rows.Count > 0;
    }
    //מוחק שורה מהסל
    public void deletecartrow(string username,string FavoriteId) //מחיקת שורה מהסל
    {
        string dlformation = "DELETE tbl_FavoriteProducts.UserName, tbl_FavoriteProducts.ProductID FROM tbl_FavoriteProducts WHERE(((tbl_FavoriteProducts.UserName) ='" + username + "') AND((tbl_FavoriteProducts.ProductID) =" + FavoriteId + "));";
        sql.udi(dlformation);
    }
    //מוציא מוצרים לפי שם המוכר
    public DataSet GetProductsBySellerName(string Name)
    {
        string stGet = "SELECT tbl_Products.ProductId, tbl_Products.Title, tbl_User.UserName, tbl_Products.DateOfUpload, tbl_Products.Category, tbl_Products.Subcategory, tbl_Products.WillingToTrade, tbl_Products.Img, tbl_Products.Condition, tbl_Products.Price, tbl_Products.Description FROM tbl_User INNER JOIN tbl_Products ON tbl_User.CustomerId = tbl_Products.SellerName WHERE(((tbl_User.UserName) ='"+Name+"'));";
        DataSet Ne = new DataSet();
        Ne = sql.chkData(stGet);
        return Ne;
    }
    //מוחק שורה מהמוצרים
    public void DeleteFromAllProducts(string DeleteId)
    {
        string dlAllProducts = "DELETE tbl_Products.ProductId FROM tbl_Products WHERE((tbl_Products.ProductId)="+DeleteId+");";
        sql.udi(dlAllProducts);
    }
    //חפש מוצר לפי שם
    public DataSet SearchProducts(string searchTxt)
    {
        //string stTest = "SELECT tbl_Products.Title, tbl_Products.Img FROM tbl_Products WHERE(((tbl_Products.Title) ='"+searchTxt+"'))";
        DataSet dsproducts = new DataSet();
        dsproducts = sql.chkData("SELECT tbl_Products.Title, tbl_Products.Img FROM tbl_Products WHERE(((tbl_Products.Title) ='" + searchTxt + "'))");
        return dsproducts;
    }
    //השג מוצר לפי תמונה
    //SELECT tbl_Products.ProductId, tbl_Products.Title, tbl_Products.Price, tbl_Products.Img FROM tbl_Products WHERE(((tbl_Products.Img)=[Enter]));
    public DataSet SearchProductsByImg(string searchTxt)
    {
        //string stTest = "SELECT tbl_Products.Title, tbl_Products.Img FROM tbl_Products WHERE(((tbl_Products.Title) ='"+searchTxt+"'))";
        DataSet dsproducts = new DataSet();
        dsproducts = sql.chkData("SELECT tbl_Products.ProductId, tbl_Products.Title, tbl_Products.Price, tbl_Products.Img FROM tbl_Products WHERE(((tbl_Products.Img)='"+searchTxt+"'))");
        return dsproducts;
    }
}