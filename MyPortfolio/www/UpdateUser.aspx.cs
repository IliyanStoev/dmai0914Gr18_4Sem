using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UpdateUser : System.Web.UI.Page
{
    SecurityHelper sch = new SecurityHelper();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        int id = Convert.ToInt32(HttpContext.Current.Session["id"]);
        UserCtrl userCtrl = new UserCtrl();

       
        _User user = userCtrl.GetUserById(id);
        

            username.Value = user.userName;
           firstName.Value = user.FirstName;
           lastName.Value = user.LastName;
           address.Value = user._Address;
           email.Value = user.email;
          
            
    }
    
    protected void UpdateUserClick(object sender, EventArgs e)
    {
        UserCtrl userCtrl = new UserCtrl();
        int id = Convert.ToInt32(HttpContext.Current.Session["id"]);
        _User user = userCtrl.GetUserById(id);


        string FirstName = null;
        string LastName = null;
        string _address = null;
        string Email = null;
        string Password = null;

        

        if (firstName2.Value.Length == 0)
        {
            FirstName = firstName.Value;
        }
        else
        {
            FirstName = firstName2.Value;
        }
        if (lastName2.Value.Length == 0)
        {
            LastName = lastName.Value;
        }
        else
        {
            LastName = lastName2.Value;
        }
        if (address2.Value.Length == 0)
        {
            _address = address.Value;
        }
        else
        {
            _address = address2.Value;
        }
        if (email2.Value.Length == 0)
        {
            Email = email.Value;
        }
        else
        {
            Email = email2.Value;
        }
        if (userPassword2.Value.Length == 0)
        {

            Password = user.password;
        }
        else
        {
            Password = userPassword2.Value;

            PasswordHash psHash = new PasswordHash();

            Password = psHash.GetHashedPassword(Password);
        }



        userCtrl.UpdateUser(id, FirstName, LastName, Email, Password, _address);
        
        Response.Redirect("Home.aspx");

    }
  

       
    
    protected void DeleteUserClick(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(HttpContext.Current.Session["id"]);

        UserCtrl userCtrl = new UserCtrl();

        userCtrl.DeleteUser(id);
        sch.LogOut();

        Response.Redirect("Home.aspx");
    }
}