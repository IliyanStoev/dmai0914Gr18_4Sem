using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ContactDB
/// </summary>
public class ContactDB : BaseDB
{
	public ContactDB()
	{

	}

    public void InsertContact(Contact contact)
    {
       


            dataContext.Contacts.InsertOnSubmit(contact);
            dataContext.SubmitChanges();
        
    }


}