using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class UserCtrl
{
    protected TUserDB TuserDB = null;
	public UserCtrl()
	{
        TuserDB = new TUserDB();
	}

    public bool ValidateUser(string userName, string password) 
    {
        _User user = TuserDB.GetUser(userName);
        if (user == null)
        {
            return false;
        }
        else
        {
            return user.password == password;
        }
    }

    public void CreateUser(string UserUsername, string firstName, string lastName, string Upassword, string Memail, string Uaddress, string sex)
    {
        _User user = new _User();
        user.userName = UserUsername;
        user.FirstName = firstName;
        user.LastName = lastName;
        user.password = Upassword;
        user.email = Memail;
        user._Address = Uaddress;
        user.sex = sex;
        

        TuserDB.SaveUser(user);
    }

    public void UpdateUser(int id, string firstName, string lastName, string email, string password, string Uaddress)
    {
        _User user = GetUserById(id);
        
        user.FirstName = firstName;
        user.LastName = lastName;
        user._Address = Uaddress;
        user.email = email;
        user.password = password;
       

        TuserDB.UpdateUser(user);
    }

    public void DeleteUser(int id)
    {
        _User user = GetUserById(id);

        TuserDB.DeleteUser(user);
    }

    public _User GetUser(string userName)
    {
        return TuserDB.GetUser(userName);


    }

    public _User GetUserById(int id)
    {
        return TuserDB.GetUserById(id);
    }


    public List<_User> GetAllUsers()
    {
        return TuserDB.GetAllUsers();
    }

   

}