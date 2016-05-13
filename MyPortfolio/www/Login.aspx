<%@ Page Title="" Language="C#" MasterPageFile="~/MpDefault.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" EnableEventValidation="false"%>
<%@ MasterType VirtualPath="~/MpDefault.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section class="title">
    <div class="container">
      <div class="row-fluid">
        <div class="span6">
          <h1>Log In</h1>
        </div>
        <div class="span6">
          <ul class="breadcrumb pull-right">
            <li><a href="index.html">Home</a> <span class="divider">/</span></li>
            <li><a href="#">Pages</a> <span class="divider">/</span></li>
            <li class="active">Login</li>
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
        </div>

        

        <div class="control-group">
          <!-- Password-->
          <div class="controls">
            <input type="password" id="userPass" name="password" placeholder="Password" class="input-xlarge" required="required" runat="server"/>
          </div>
        </div>

        

        <div class="control-group">
          <!-- Button -->
          <div class="controls">
             <asp:Button class="btn btn-success btn-large btn-block" runat="server" OnClick="LogInClick" Text="Log In" />
            
          </div>
        </div>
      </fieldset>
   
     
  </section>
    
</asp:Content>

