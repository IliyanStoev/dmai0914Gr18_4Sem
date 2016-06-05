using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using SendGrid;

public partial class Contact : System.Web.UI.Page
{
    private SecurityHelper sch = new SecurityHelper();
    protected void Page_Load(object sender, EventArgs e)
    {
        Master.PageID = "Contact";

        sch.CheckSecurity();
        if(sch.IsLoggedIn)
        {
            int uId = sch.Id;
            UserCtrl userCtrl = new UserCtrl();
            _User user = userCtrl.GetUserById(uId);

            senderTb.Text = user.email;
            firstNameTb.Text = user.FirstName;
            lastNameTb.Text = user.LastName;
            senderTb.Enabled = false;
            firstNameTb.Enabled = false;
            lastNameTb.Enabled = false;
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }
    protected void sendBtn_Click(object sender, EventArgs e)
    {
        SendGridMessage theMessage = new SendGridMessage();

        theMessage.From = new MailAddress(senderTb.Text);

        theMessage.AddTo("c20xe@mail.bg");

        theMessage.Subject = subjectTb.Text;

        theMessage.Text = messageTb.Text;

        string userName = "";
        string password = "";

        var credentials = new NetworkCredential(userName, password);

        Web transportWeb = new Web(credentials);

        transportWeb.DeliverAsync(theMessage);

        SaveContact();

        ClearFields();
    }


    private void ClearFields()
    {
        //firstNameTb.Text = "";
        //lastNameTb.Text = "";
        //senderTb.Text = "";
        subjectTb.Text = "";
        messageTb.Text = "";

    }
    

    private void SaveContact()
    {
        ContactCtrl contCtrl = new ContactCtrl();

        contCtrl.InsertContact(messageTb.Text, subjectTb.Text, DateTime.Now, sch.Id);
    }
}