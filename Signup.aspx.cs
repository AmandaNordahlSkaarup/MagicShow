using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace LasVegasMagicShow
{
    public partial class Signup : System.Web.UI.Page
    {
        ArrayList userarray;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["users"] == null)
            {
                userarray = new ArrayList();
                Application["users"] = userarray;
            }
            userarray = (ArrayList)Application["users"];
            TextBox_sp_password.TextMode = TextBoxMode.Password;
        }

        protected void Button_sp_signup_Click(object sender, EventArgs e)
        {
            if (RadioButtonList_usertype.SelectedValue == "Magician")
            {
                Magicians m = new Magicians(Convert.ToInt32(userarray.Count + 1), TextBox_sp_username.Text, TextBox_sp_password.Text, 1);
                userarray.Add(m);
                Response.Redirect("Index.aspx");
            }
            else
            {
                Staff s = new Staff(Convert.ToInt32(userarray.Count + 1), TextBox_sp_username.Text, TextBox_sp_password.Text, 2);
                userarray.Add(s);
                Response.Redirect("Index.aspx");
            }
        }
    }
}