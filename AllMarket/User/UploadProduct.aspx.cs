using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class User_UploadProduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["userName"] == null)
        {
            Response.Redirect("./Login.aspx");
        }
        else
        {
            txt_date.Text = DateTime.Now.ToString("dddd, MMMM dd");
        }
    }





    protected void btn_UploadProduct_Click(object sender, EventArgs e)
    {   // ניתן לבדוק אורך כי אם הוא הגיע לשם ניתן לדעת שהוא עבר גבר בדיקה לראות אם הוא ריק כי אם היה ריק הIF היה עוצר בהתחלה
        if (Fu_Img.HasFile && txt_date.Text != null && txt_description != null && txt_price != null && txt_title != null && txt_description.Text.Length<42 && txt_title.Text.Length<29)
        {
            Fu_Img.SaveAs(Server.MapPath("ImgProducts//" + Fu_Img.FileName.ToString()));
            lbl_t.Text = Fu_Img.FileName.ToString();
            image_upload_preview.ImageUrl = "../User/ImgProducts/" + lbl_t.Text;

            Products NewProduct = new Products();
            NewProduct.img = "../User/ImgProducts/" + Fu_Img.FileName.ToString();
            NewProduct.title = txt_title.Text;
            NewProduct.price = txt_price.Text;
            //NewProduct.category להמשיך להעלות
            users TmpUser = new users();
            NewProduct.sellerName = TmpUser.GetIDByUserName( Session["userName"].ToString());
            NewProduct.description = txt_description.Text;
            NewProduct.dateOfUpload = txt_date.Text;
            NewProduct.category = ddl_Category.SelectedItem.Value;
            NewProduct.condition = ddl_Condition.SelectedItem.Value;
            NewProduct.addProduct(NewProduct);
            lbl_Error.Text = "המוצר הועלה בהצלחה";
            lbl_Error.Visible = true;
          }
    }



    protected void btn_MyProducts_Click(object sender, EventArgs e)
    {
        Response.Redirect("./MyProducts.aspx");
    }

    protected void btn_login_goto_Click(object sender, EventArgs e)
    {
        Session["userName"] = null;
        Response.Redirect("./Login.aspx");
    }

    protected void btn_register_goto_Click(object sender, EventArgs e)
    {
        Session["userName"] = null;
        Response.Redirect("./Register.aspx");
    }

    protected void Button1_Click_Index(object sender, EventArgs e)
    {
        Response.Redirect("./Index.aspx");
    }
}