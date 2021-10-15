using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data;

namespace LasVegasMagicShow
{
    public partial class Admin : System.Web.UI.Page
    {
        object user;
        object userlvl;
        ArrayList allusers;
        protected void Page_Load(object sender, EventArgs e)
        {
allusers = (ArrayList)Application["users"];
            user = Session["currentUser"];
            userlvl = Session["currentLevel"];
            Label_login.Text = "WELCOME: " + user;
            if (userlvl.ToString() == "Magicians")
            {
                Magicians currentm = (Magicians)user;
                TextBoxSal.Visible = false;
                Label3.Visible = false;
                Userinfo.Text = "<li> Name: " + currentm.Name + "</li>" + "<li> Level: " + userlvl.ToString() + "</li>" + "<li> Password: " + currentm.Password + "</li>" + "<li> Favorite tricks: " + currentm.displayTricks() + " </ li > ";
                for (int i = 0; i < allusers.Count; i++)
                {
                    if (allusers[i].GetType().Name == "Magicians")
                    {
                        ListBoxUsers.Items.Add(allusers[i].ToString());
                    }
                }
            }
            else
            {
                Staff currents = (Staff)user;
                TextBoxFavTricks.Visible = false;
                Label4.Visible = false;
                Userinfo.Text = "<li> Name: " + currents.Name + "</li>" + "<li> Level: " + userlvl.ToString() + "</li>" + "<li> Password: " + currents.Password + "</li>" + "<li> Salary: " + currents.Salary + "</li>";

                foreach (var user in allusers)
                {
                    ListBoxUsers.Items.Add(user.ToString());
                }
            }
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < allusers.Count; i++)
            {
                if (allusers[i].ToString() == user.ToString())
                {
                    if (userlvl.ToString() == "Magicians")
                    {
                        Magicians m = (Magicians)allusers[i];
                        m.Name = TextBoxName.Text;
                        m.Password = TextBoxPass.Text;
                        m.AddFavoriteTrick(TextBoxFavTricks.Text);
                        user = m;
                        Session["currentUser"] = user;
                        Response.Redirect("Admin.aspx");
                    }
                    else
                    {
                        Staff s = (Staff)allusers[i];
                        s.Name = TextBoxName.Text;
                        s.Password = TextBoxPass.Text;
                        s.Salary = Convert.ToInt32(value: TextBoxSal.Text);
                        user = s;
                        Session["currentUser"] = user;
                        Response.Redirect("Admin.aspx");
                    }

                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < allusers.Count; i++)
            {
                if (allusers[i].ToString() == user.ToString())
                {
                    if (userlvl.ToString() == "Magicians")
                    {
                        Magicians m = (Magicians)allusers[i];
                        m.AddFavoriteTrick(TextBoxFavTricks.Text);
                        user = m;
                        Session["currentUser"] = user;
                        Response.Redirect("Admin.aspx");
                    }
                    else
                    {
                        Staff s = (Staff)allusers[i];
                        s.Salary = Convert.ToInt32(value: TextBoxSal.Text);
                        user = s;
                        Session["currentUser"] = user;
                        Response.Redirect("Admin.aspx");
                    }

                }
            }
        }

    }
}