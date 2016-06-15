<%@ Page Title="" Language="C#" MasterPageFile="~/MpDefault.master" AutoEventWireup="true" CodeFile="UpdateUser.aspx.cs" Inherits="UpdateUser" EnableEventValidation="false" %>
<%@ MasterType VirtualPath="~/MpDefault.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section class="title">
    <div class="container">
      <div class="row-fluid">
        <div class="span6">
          <h1>User Profile</h1>
        </div>
        <div class="span6">
          <ul class="breadcrumb pull-right">
            <li><a href="Home.aspx">Home</a> <span class="divider">/</span></li>
           
            <li class="active">User Profile</li>
          </ul>
        </div>
      </div>
    </div>
  </section>
  <!-- / .title -->       


  <section id="registration-page" class="container; center">
   
      <fieldset class="registration-form">
        <div class="control-group">
          <!-- Username -->
          <div class="controls">
             
            <input type="text" id="username" placeholder="Username" class="input-xlarge" required="required" runat="server" readonly="true"/> <input type="text" id="userName2" placeholder="Username" class="input-xlarge" runat="server"/>
          </div>
        </div>
          <div class="control-group">
          <!-- Username -->
          <div class="controls">
            <input type="text" id="firstName" placeholder="First Name" class="input-xlarge"  runat="server" readonly="true"/> <input type="text" id="firstName2" placeholder="New First Name" class="input-xlarge" runat="server"/>
          </div>
              <asp:RegularExpressionValidator ID="regexpFirstName2" runat="server" CssClass="alert-error" ErrorMessage="First Name must be minimum of 3 chars" ControlToValidate="firstName2" ValidationExpression="^[a-zA-Z]{3,40}$" />
        </div>

          <div class="control-group">
          <!-- Username -->
          <div class="controls">
            <input type="text" id="lastName" placeholder="Last Name" class="input-xlarge" runat="server" readonly="true"/> <input type="text" id="lastName2" placeholder="New Last Name" class="input-xlarge" runat="server"/>
          </div>
              <asp:RegularExpressionValidator ID="regexpLastName" runat="server" CssClass="alert-error" ErrorMessage="Last Name must be minimum of 3 chars" ControlToValidate="lastName2" ValidationExpression="^[a-zA-Z]{3,40}$" />
        </div>

          <div class="control-group">
          <!-- Username -->
          <div class="controls">
            <input type="text" id="address" placeholder="Address" class="input-xlarge"  runat="server" readonly="true"/> <input type="text" id="address2" placeholder="New Address" class="input-xlarge" runat="server"/>
          </div>
        </div>

        <div class="control-group">
          <!-- E-mail -->
          <div class="controls">
            <input type="text" id="email" placeholder="E-mail" class="input-xlarge" runat="server" readonly="true"/> <input type="text" id="email2" placeholder="New Email" class="input-xlarge" runat="server"/>
          </div>
            <asp:RegularExpressionValidator ID="regexpEmail" runat="server" CssClass="alert-error" ErrorMessage="Not valid email format" ControlToValidate="email2" ValidationExpression="^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$"></asp:RegularExpressionValidator>
        </div>

        <div class="control-group">
          <!-- Password-->
          <div class="controls">
             
            <input type="password" id="userPassword2" placeholder="New Password" class="input-xlarge"  runat="server"/>
          </div>
        </div>

        

        <div class="control-group">
          <!-- Button -->
          <div class="controls">
              <asp:Button class="btn btn-success btn-large" Text="Update" runat="server" OnClick="UpdateUserClick" OnClientClick="return confirm('Are you sure?');" />
              <asp:Button class="btn btn-success btn-large" Text="Suspend Account" runat="server" OnClick="DeleteUserClick" OnClientClick="return confirm('Are you sure?');"/>
              
              
            
          </div>
        </div>
      </fieldset>
      <a href="OrderHistory.aspx" class="links">View Orders History</a>
      
   
  </section>
    
</asp:Content>

