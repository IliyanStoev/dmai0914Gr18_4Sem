using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Master.PageID = "Registration";
    }
    protected void registerClick(object sender, EventArgs e)
    {
        UserCtrl userCtrl = new UserCtrl();

        string userName = username.Value;
        string FirstName = firstName.Value;
        string LastName = lastName.Value;
        string _address = address.Value;
        string password = userPassword.Value;
        string userEmail = email.Value;
        string sex = "";
        if (radioMale.Checked)
        {
            sex = "Male";
        }
        else if(radioFemale.Checked)
        {
            sex = "Female";
        }

        PasswordHash pshash = new PasswordHash();
        
        string dbPass = pshash.GetHashedPassword(password);

       
        
            userCtrl.CreateUser(userName, FirstName, LastName, dbPass, userEmail, _address, sex);
            Response.Redirect("Success.aspx");
        




        
       
    }
}