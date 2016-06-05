using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MpDefault : System.Web.UI.MasterPage
{
    private SecurityHelper sch;
    public string PageID { get; set; }
    protected void Page_Load(object sender, EventArgs e)
    {
       
            switch (PageID)
        {
                case "Home":
                homeMenuItem.Attributes["class"] = "active";
                break;

                 case "Contact":
                contactMenuItem.Attributes["class"] = "active";
                break;

                /*case "About Me":
                aboutMenuItem.Attributes["class"] = "active";
                break; */

                case "Registration":

                registerMenuItem.Attributes["class"] = "active";
                break;

                case "Login":
                loginMenuItem.Attributes["class"] = "active";
                break;

                case "Calculators":
                calcMenuItem.Attributes["class"] = "active";
                break;

                case "Shop":
                shopMenuItem.Attributes["class"] = "active";
                break;
                
            default:
                break;
        }

        Page.Title = PageID;
        IsLoggedIn();
    }
    private void IsLoggedIn()
    {
        sch = new SecurityHelper();

        sch.CheckSecurity();

        if (sch.IsLoggedIn)
        {
            displayNameLabel.Text = "Logged in as:" + sch.DisplayName;
            LogMenuLabel.Text = "Log Out";
            registerMenuItem.Visible = false;
        }
        
    }

    

    protected void LogMenuLabel_Click(object sender, EventArgs e)
    {
        if(LogMenuLabel.Text.Equals("Log In")) 
        {
            Response.Redirect("Login.aspx");
        }
        else if(LogMenuLabel.Text.Equals("Log Out"))
        {
            sch.LogOut();
            Response.Redirect("Home.aspx");
        }
    }
}

