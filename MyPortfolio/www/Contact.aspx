<%@ Page Title="" Language="C#" MasterPageFile="~/MpDefault.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>
<%@ MasterType VirtualPath="~/MpDefault.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section class="no-margin">
        <iframe width="100%" height="200" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2169.9470393236493!2d9.905581315981431!3d57.05244498092082!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x46493261a31d8be9%3A0x7b6c10b0d0bba38c!2sAbsalonsgade+35%2C+9000+Aalborg!5e0!3m2!1sbg!2sdk!4v1459253286674"></iframe>
    </section>

    <section id="contact-page" class="container">
        <div class="row-fluid">

            <div class="span8">
                <h4>Contact Form</h4>
                <div class="status alert alert-success" style="display: none"></div>

                
                  <div class="row-fluid">
                    <div class="span5">
                        <label>First Name</label>
                        <asp:TextBox runat="server" CssClass="input-block-level" ID="firstNameTb"></asp:TextBox>
                        
                        <label>Last Name</label>
                        <asp:TextBox runat="server" CssClass="input-block-level" ID="lastNameTb"></asp:TextBox>
                        
                        <label>Email Address</label>
                        <asp:TextBox runat="server" CssClass="input-block-level" ID="senderTb"></asp:TextBox> <asp:RegularExpressionValidator ID="regexEmailValid" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="senderTb" ErrorMessage="Invalid Email Format" CssClass="alert-error"></asp:RegularExpressionValidator>
                        
                    </div>
                    <div class="span7">
                        <label>Subject</label>
                        <asp:TextBox runat="server" CssClass="input-block-level" ID="subjectTb"></asp:TextBox>
                        
                        
                        <label>Message</label>
                        <asp:TextBox runat="server"  ID="messageTb" CssClass="input-block-level" Rows="8" Columns="30" TextMode="MultiLine"></asp:TextBox>
                       
                    </div>

                </div>
                  
               
                <asp:Button runat="server" CssClass="btn btn-primary btn-large pull-right" ID="sendBtn" Text="Send" OnClick="sendBtn_Click" />
                <p> </p>

            
        </div>

        <div class="span3">
            <h4>My Address</h4>
            
            <p>
                <i class="icon-map-marker pull-left"></i> Absalonsgade 35, Aalborg<br>

            </p>
            <p>
                <i class="icon-envelope"></i> &nbsp;stoev1989@gmail.com
            </p>
            <p>
                <i class="icon-phone"></i> &nbsp;+123 45 67 89
            </p>
            <p>
                <i class="icon-globe"></i> &nbsp; <a href="http://myportfolio.com">www.myportfolio.com</a>
            </p>
        </div>

    </div>

</section>
</asp:Content>

