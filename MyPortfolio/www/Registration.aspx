<%@ Page Title="" Language="C#" MasterPageFile="~/MpDefault.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" EnableEventValidation="false" %>
<%@ MasterType VirtualPath="~/MpDefault.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section class="title">
    <div class="container">
      <div class="row-fluid">
        <div class="span6">
          <h1>Registration</h1>
        </div>
        <div class="span6">
          <ul class="breadcrumb pull-right">
            <li><a href="Home.aspx">Home</a> <span class="divider">/</span></li>
           
            <li class="active">Registration</li>
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
            <input type="text" id="username" name="username" placeholder="Username" class="input-xlarge" required="required" runat="server"/>
         </div>
            <asp:RegularExpressionValidator ID="regexpUserName" runat="server" CssClass="alert-error" ErrorMessage="Username must be atleast 6 and maximum of 16 chars" ControlToValidate="username" ValidationExpression="^[a-zA-Z'.\s]{6,16}$" />
        </div>
          <div class="control-group">
          <!-- First Name -->
          <div class="controls">
            <input type="text" id="firstName" name="firstName" placeholder="First Name" class="input-xlarge" required="required" runat="server"/>
          </div>
              <asp:RegularExpressionValidator ID="regexpFirstName" runat="server" CssClass="alert-error" ErrorMessage="First Name must be minimum of 3 chars" ControlToValidate="firstName" ValidationExpression="^[a-zA-Z]{3,40}$" />
        </div>

          <div class="control-group">
          <!-- Last Name -->
          <div class="controls">
            <input type="text" id="lastName" name="lastName" placeholder="Last Name" class="input-xlarge" required="required" runat="server"/>
           </div>
              <asp:RegularExpressionValidator ID="regexpLastName" runat="server" CssClass="alert-error" ErrorMessage="Last Name must be minimum of 3 chars" ControlToValidate="lastName" ValidationExpression="^[a-zA-Z]{3,40}$" />
        </div>

          <div class="control-group">
          <!-- Address -->
          <div class="controls">
            <input type="text" id="address" name="address" placeholder="Address" class="input-xlarge" runat="server"/>
          </div>
        </div>

        <div class="control-group">
          <!-- E-mail -->
          <div class="controls">
            <input type="text" id="email" name="email" placeholder="E-mail" class="input-xlarge" required="required" runat="server"/>
              
          </div>
            <asp:RegularExpressionValidator ID="regexpEmail" runat="server" CssClass="alert-error" ErrorMessage="Not valid email format" ControlToValidate="email" ValidationExpression="^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$"></asp:RegularExpressionValidator>
        </div>

        <div class="control-group">
          <!-- Password-->
          <div class="controls">
             
            <input type="password" id="userPassword" name="password" placeholder="Password" class="input-xlarge" required="required" runat="server"/>
          </div>
        </div>

          <label class="label">Male</label><input type="radio" id="radioMale" required="required" runat="server" /><label class="label">Female</label> <input type="radio" id="radioFemale" runat="server" required="required"/>
 
       

        <div class="control-group">
          <!-- Button -->
          <div class="controls">
              <asp:Button class="btn btn-success btn-large btn-block" Text="Register" runat="server" OnClick="registerClick"/>
            
          </div>
        </div>
      </fieldset>
   
  </section>
</asp:Content>

