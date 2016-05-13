using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TUserDB
/// </summary>
public class TUserDB : BaseDB
{
    public _User GetUser(string userName)
    {
        
            return dataContext._Users.Where(x => x.userName == userName).FirstOrDefault();
        
    }

    public _User GetUserById(int id)
    {
            return dataContext._Users.Where(x => x.id == id).FirstOrDefault();
        
    }

    public void UpdateUser(_User user)
    {
        
            
            dataContext.SubmitChanges();
        
    }

    public List<_User> GetAllUsers()
    {
        
            return dataContext._Users.ToList();
        
    }

    public void SaveUser(_User user)
    {
        
            dataContext._Users.InsertOnSubmit(user);
            dataContext.SubmitChanges();
        

    }

    public void DeleteUser(_User user)
    {
       
            dataContext._Users.DeleteOnSubmit(user);
            dataContext.SubmitChanges();
        
    }

   
}