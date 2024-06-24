using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_recipt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lbl_numorder.Text = Session["orderid"].ToString();
        string card = "",temp = Session["card"].ToString();
        for (int i = 12; i <= 15; i++)
        {
            card = card + temp[i];
        }
        lbl_card.Text = "**** **** **** " + card;
    }
}