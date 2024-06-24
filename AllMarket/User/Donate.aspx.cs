using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_Donate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }


    protected void btn_Donate_Click(object sender, EventArgs e)
    {
        if (AreFieldsValid()&& ChoseAmountToDonate())
        {
            ServiceReference1.ServiceSoapClient BankServer = new ServiceReference1.ServiceSoapClient();
            if (BankServer.chkCard(txt_CardNumber.Text, txt_Month.Text, txt_Year.Text, ddl_CardType.SelectedItem.ToString(), txt_CVC.Text,txt_Id.Text))
            {
                DateTime dateTime = DateTime.UtcNow.Date;
                CreditCardDonation CCD1 = new CreditCardDonation();
                CCD1.InsertNewDonation(dateTime.ToString("dd/MM/yyyy"), txt_Amount.Text, txt_Id.Text);
                lbl_Error.Visible = true;
                lbl_Error.Text = "התרומה בוצעה בהצלחה";
                grd_receipt.Visible = true;
                grd_receipt.DataSource = CCD1.GetReceiptsFromDonorID(txt_Id.Text);
                grd_receipt.DataBind();
                GridViewRow FirstRow = grd_receipt.Rows[1];
                foreach (GridViewRow row in grd_receipt.Rows)
                {
                    row.Visible = false;
                }
                FirstRow.Visible = true;
                lbl_receipt.Visible = true;
            }
            else
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "פרטי כרטיס האשראי אינם נכונים";
            }
        }
        else
        {
            lbl_Error.Visible = true;
            lbl_Error.Text = "אחד או יותר מן השדות אינם נכונים";
        }
    }

    // בודק אם תחומי האשראי הוכנסו כמו שצריך
    protected bool AreFieldsValid()
    {
        // Check if the credit card number is not empty
        if (string.IsNullOrEmpty(txt_CardNumber.Text.Trim()))
            return false;

        // Check if the ID number is not empty
        if (string.IsNullOrEmpty(txt_Id.Text.Trim()))
            return false;

        // Check if the expiration year and month are valid (you can add more specific checks)
        int year;
        if (!int.TryParse(txt_Year.Text.Trim(), out year) || year < DateTime.Now.Year)
            return false;

        int month;
        if (!int.TryParse(txt_Month.Text.Trim(), out month) || month < 1 || month > 12)
            return false;

        // Check if the CVC is not empty
        if (string.IsNullOrEmpty(txt_CVC.Text.Trim()))
            return false;

        // Check if a card type is selected (assuming the first item is not a valid selection)
        if (ddl_CardType.SelectedIndex <= 0)
            return false;

        // All fields are valid
        return true;
    }

    //בודק אם שמו סכום מסיום לתרום
    protected bool ChoseAmountToDonate()
    {
        // Check if an amount is selected from the DropDownList
        if (ddl_Amount.SelectedIndex <= 0)
            return false;

        // Check if a custom amount is entered (if applicable)
        if (ddl_Amount.SelectedItem.Text == "סכום שונה")
        {
            // Validate the custom amount (you can add more specific checks)
            decimal customAmount;
            if (!decimal.TryParse(txt_Amount.Text.Trim(), out customAmount) || customAmount <= 0)
                return false;
        }

        // All fields are valid
        return true;
    }


    protected void ddl_Amount_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddl_Amount.SelectedIndex == 0 || ddl_Amount.SelectedIndex == 4)
        {
            txt_Amount.Text = "";
        }
        else
        {
            txt_Amount.Text = ddl_Amount.SelectedItem.Text.Substring(0,2);
        }
    }

    protected void btn_Index_Click(object sender, EventArgs e)
    {
        Response.Redirect("./Index.aspx");
    }
}