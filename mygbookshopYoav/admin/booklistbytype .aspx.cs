using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_booklistbytype_ : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        grd_Type.Visible = false;
        Label2.Visible = false;
    }

    protected void ddl_Types_SelectedIndexChanged(object sender, EventArgs e)
    {
        books bookType = new books();
        bookType.BookType = ddl_Types.SelectedItem.Text;
        grd_Type.DataSource = bookType.bookByType(bookType).Tables[0];
        grd_Type.DataBind();
        if(grd_Type.Rows.Count == 0 )
        {
            Label2.Visible = true;
            Label2.Text = "אין ספרים מסוג זה";
        }
        else
        {
            grd_Type.Visible = true;
            Label2.Visible = true;
            Label2.Text = "כמות ספרים: " + grd_Type.Rows.Count;
        }
    }
}