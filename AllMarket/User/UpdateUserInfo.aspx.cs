using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_UpdateUserInfo : System.Web.UI.Page
{
    users UpdateUser = new users();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userName"] == null)
        {
            Response.Redirect("./Index.aspx");
        }
        else
        {
            //מונע מהדף לרוץ פעמיים ולאבד את העדכון
            if (Session["yy"].Equals(false))
            {
                grd_user.DataSource = UpdateUser.GetUserByUsername(Session["userName"].ToString());
                grd_user.DataBind();
                txt_Username.Text = Session["userName"].ToString();
                foreach (GridViewRow row in grd_user.Rows)
                {
                    txt_Fname.Text = row.Cells[4].Text;
                    txt_Lname.Text = row.Cells[5].Text;
                    txt_Password.Text = row.Cells[2].Text;
                    txt_Email.Text = row.Cells[10].Text;
                    txt_PhoneNumber.Text = row.Cells[8].Text.Remove(0,3);
                    txt_Address.Text = row.Cells[7].Text;
                    ddl_Gender.SelectedIndex = int.Parse(row.Cells[6].Text)-1;
                    ddl_City.SelectedIndex = int.Parse(row.Cells[9].Text)-1;
                    ddl_PhoneStart.SelectedValue = row.Cells[8].Text.Substring(0,3);
                }
                Session["yy"] = true;
            }
        }
    }

    // מעדכן את טבלת tbl_User לפי הערכים החדשים
    protected void btn_Update_Click(object sender, EventArgs e)
    {
        
        if (!(txt_Username.Text == "" || txt_PhoneNumber.Text == "" || txt_Password.Text == "" || txt_Lname.Text == "" || txt_Fname.Text == "" || txt_Email.Text == "" || txt_Address.Text == ""))
        {
            UpdateUser.Pass = txt_Password.Text;
            UpdateUser.PhoneNumber = ddl_PhoneStart.SelectedItem.Value.ToString() + txt_PhoneNumber.Text;
            UpdateUser.FName = txt_Fname.Text;
            UpdateUser.LName = txt_Lname.Text;
            UpdateUser.Gender = ddl_Gender.SelectedItem.Value.ToString();
            UpdateUser.CityName = ddl_City.SelectedItem.Value.ToString();
            UpdateUser.Addres = txt_Address.Text;
            UpdateUser.User_Name = txt_Username.Text;
            UpdateUser.Mail =txt_Email.Text;
            UpdateUser.UpdateUserInfo(UpdateUser,Session["userName"].ToString());
            lbl_error.Visible = true;
            lbl_error.Text = "הפרטים עודכנו בהצלחה";
        }
    }

    protected void btn_index_Click(object sender, EventArgs e)
    {
        Response.Redirect("./Index.aspx");
    }
}