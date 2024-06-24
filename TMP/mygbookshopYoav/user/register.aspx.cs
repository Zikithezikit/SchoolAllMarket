using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        btn_login.Visible = false;
        lblSucc.Visible = false;
        lblFail.Visible = false;
    }


    protected void btn_login_Click(object sender, EventArgs e)
    {
        Response.Redirect("./loginuser.aspx");
    }

    protected void btn_register_Click(object sender, EventArgs e)
    {
        //הכנסת הנתונים לטבלת משתמשים על ידי מחלקת users ושימוש בפעולות אם משתמש קיים והוספת משתמש חדש
        users user = new users();
        string stphone = ddl_prefix.SelectedItem.Text + txtPhone.Text;
        user.FName = txtFname.Text;
        user.LName = txtname.Text;
        user.Addres = txtAdress.Text;
        user.CityName = DropDownList1.SelectedItem.Value;
        user.Gender = rbl_Gender.SelectedItem.Value;
        user.PhoneNumber = stphone;
        user.Mail = txtxmail.Text;
        user.User_Name = txtuser.Text;
        user.Pass = txtpass.Text;
        if (!user.ifExistes(user))
        {
            user.addUser(user);
            btn_login.Visible = true;
            lblSucc.Visible = true; 
        }
        else
        {
            lblFail.Visible = true;
        }

    }
}