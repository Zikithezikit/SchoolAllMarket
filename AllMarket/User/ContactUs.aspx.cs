using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_ContactUs : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        txt_date.Text = DateTime.Now.ToString("dddd, MMMM dd");
    }

    protected void btn_UploadProduct_Click(object sender, EventArgs e)
    {
        if(txt_Comment != null && txt_Email != null)
        {
            users AddComment = new users();
            AddComment.addComment(txt_date.Text, txt_Comment.Text, txt_Email.Text);
            lbl_Upload.Text = "התגובה הועלה בהצלחה";
            lbl_Upload.Visible = true;
        }
    }

    protected void btn_Index_Click(object sender, EventArgs e)
    {
        Response.Redirect("./Index.aspx");
    }
}