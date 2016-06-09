using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : SecurityHelper
{
    protected void Page_Load(object sender, EventArgs e)
    {

        
            Master.PageID = "Login";

        
        

    }

    protected void LogInClick(object sender, EventArgs e)
    {
        UserCtrl userCtrl = new UserCtrl();

        string userName = username.Value;
        string password = userPass.Value;

        PasswordHash psHash = new PasswordHash();
        string loginPass = psHash.GetHashedPassword(password);


        _User user = userCtrl.ValidateUser(userName, loginPass);
        //bool validate = userCtrl.ValidateUser(userName, loginPass);

        if (user != null)
        {
            if (user.acc_Status != false)
            {
                SecurityHelper sch = new SecurityHelper();
                sch.LogIn(userName, userCtrl.GetUser(userName).id);

                Response.Redirect("/Home.aspx");
            }
            else
            {
                Response.Redirect("AccSuspended.aspx");
            }
        }
        else
        {
            Response.Redirect("/404.aspx");
        }
    }
}