using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class ContactCtrl
{
    protected ContactDB contDb = null;
	public ContactCtrl()
	{
        contDb = new ContactDB();
	}

    public void InsertContact(string comment, string subject, DateTime contactDate, int userId)
    {
        Contact contact = new Contact();

        contact.Comment = comment;
        contact._subject = subject;
        contact.ContactDate = contactDate;
        contact.userId = userId;

        contDb.InsertContact(contact);
    }
}