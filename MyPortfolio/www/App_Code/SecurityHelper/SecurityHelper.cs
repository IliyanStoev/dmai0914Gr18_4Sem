using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SecurityHelper
/// </summary>
public class SecurityHelper : System.Web.UI.Page
{

    private bool isLoggedIn;
    private string displayName;
    private int id;
	public void CheckSecurity() 
	{
        if (HttpContext.Current.Session["valid"] != null)
        {
            isLoggedIn = true;
        }
        if (HttpContext.Current.Session["id"] != null)
        {
            id = Convert.ToInt32(HttpContext.Current.Session["id"]);
        }
        if (HttpContext.Current.Session["username"] != null)
        {

            displayName = HttpContext.Current.Session["username"].ToString();
        }
	}

    public void LogOut()
    {
        HttpContext.Current.Session["username"] = null;
        HttpContext.Current.Session["id"] = null;
        HttpContext.Current.Session["valid"] = null;
        HttpContext.Current.Session["myList"] = null;
        HttpContext.Current.Session["order"] = null;
    }

    public void LogIn(string userName, int id)
    {
        HttpContext.Current.Session["username"] = userName;
        HttpContext.Current.Session["id"] = id;
        HttpContext.Current.Session["valid"] = true;
       
    }

    public bool IsLoggedIn
    {
        get { return isLoggedIn; }
    }

    public int Id
    {
        get { return this.id; }
    }

    public string DisplayName
    {
        get { return this.displayName; }
    }
}