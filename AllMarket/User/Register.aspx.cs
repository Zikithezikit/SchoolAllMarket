using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_Register : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void btn_GuestClick(Object sender, EventArgs e)
    {
        Session["userName"] = null;
        Response.Redirect("./Index.aspx");
    }
    public void btn_RegisterClick(Object sender, EventArgs e)
    {
        ServiceReference2.ServiceSoapClient EmailServer = new ServiceReference2.ServiceSoapClient();
        users newUser = new users();
        if(!(txt_Username.Text == "" || txt_PhoneNumber.Text == "" || txt_Password.Text == "" || txt_Lname.Text == "" || txt_Fname.Text == "" || txt_Email.Text == ""||txt_Address.Text==""))
        {
            newUser.User_Name = txt_Username.Text;
            newUser.Mail = txt_Email.Text;
            if (newUser.ifExistes(newUser))
            {
                lbl_error.Text = "שם משתמש תפוס";
                lbl_error.Visible = true;
            }
            else if (newUser.ifExistesEmail(newUser))
            {
                lbl_error.Text = "אימייל תפוס";
                lbl_error.Visible = true;
            }
            else if (!(EmailServer.IsEmailValid(txt_Email.Text)))
            {
                lbl_error.Text = "אימייל לא קיים";
                lbl_error.Visible = true;
            }
            else
            {
                lbl_error.Visible = false;
                newUser.Pass = txt_Password.Text;
                newUser.PhoneNumber = ddl_PhoneStart.SelectedItem.Value.ToString() + txt_PhoneNumber.Text;
                newUser.FName = txt_Fname.Text;
                newUser.LName = txt_Lname.Text;
                newUser.Gender = ddl_Gender.SelectedItem.Value.ToString();
                newUser.CityName = ddl_City.SelectedItem.Value.ToString();
                newUser.Addres = txt_Address.Text;
                newUser.addUser(newUser);
                Session["userName"] = txt_Username.Text;
                Response.Redirect("~/User/Index.aspx");
            }
        }
        else
        {
            lbl_error.Text = "חלק או כל השדות ריקים";
            lbl_error.Visible = true;
        }
        
    }
}