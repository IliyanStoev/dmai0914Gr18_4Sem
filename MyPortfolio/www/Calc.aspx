<%@ Page Title="" Language="C#" MasterPageFile="~/MpDefault.master" AutoEventWireup="true" CodeFile="Calc.aspx.cs" Inherits="Calc" EnableEventValidation="false" %>
<%@ MasterType VirtualPath="~/MpDefault.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section class="title">
    <div class="container">
      <div class="row-fluid">
        <div class="span6">
          <h1>Calculators</h1>
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


  <section id="registration-page" class="container" >
    
      <fieldset class="registration-form">
        <div class="control-group">
          <!-- Username -->
          <div class="controls">
            <input type="text" id="BMRweight" name="Weight" placeholder="Weight in KG" class="input-xlarge" required="required" runat="server"/>
              <asp:RegularExpressionValidator CssClass="alert-error" ID="weightValidator" runat="server" ErrorMessage="Input must be a number" ValidationExpression="^[0-9]+$" ControlToValidate="BMRweight"></asp:RegularExpressionValidator>
              <select id="calorieDd" name="Choose Your Activity" runat="server">
                  <option id="little" runat="server">little or no exercise</option>
                  <option id="light" runat="server">light exercise/sports 1-3 days/week</option>
                  <option id="moderate" runat="server">moderate exercise/sports 3-5 days/week</option>
                  <option id="hard" runat="server">hard exercise/sports 6-7 days a week</option>
                  <option id="veryHard" runat="server">very hard exercise/sports & physical job or 2x training</option>
              </select>

                

              
          </div>
        </div>

        

        <div class="control-group">
          <!-- Password-->
          <div class="controls">
            <input type="text" id="BMRheight" name="Height" placeholder="Height in CM" class="input-xlarge" required="required" runat="server"/>
              <asp:RegularExpressionValidator CssClass="alert-error" ID="heightValidator" runat="server" ErrorMessage="Input must be a number" ValidationExpression="^[0-9]+$" ControlToValidate="BMRheight"></asp:RegularExpressionValidator>
          </div>
        </div>

          <div class="control-group">
          <!-- Password-->
          <div class="controls">
            <input type="text" id="BMRage" name="Age" placeholder="Age" class="input-xlarge" required="required" runat="server"/>
              <asp:RegularExpressionValidator CssClass="alert-error" ID="ageValidator" runat="server" ErrorMessage="Input must be a number" ValidationExpression="^[0-9]+$" ControlToValidate="BMRage"></asp:RegularExpressionValidator>
          </div>
        </div>

          <div class="control-group">
          <!-- Password-->
          <div class="controls">
           Male     <input type="radio" id="BMRradioM" name="Sex" placeholder="Male" class="input-xlarge" required="required" runat="server"/>
           Female  <input type="radio" id="BMRradioF" name="Sex" placeholder="Female" class="input-xlarge" required="required" runat="server"/>
           <input type="text" id="BMR" name="BMR" placeholder="BMR" class="input-xlarge" runat="server" readonly="true"/> <input type="text" id="dailyCals" name="Daily Calories Needed" placeholder="Daily Calories Needed" class="input-xlarge" runat="server" readonly="true"/>
          </div>
        </div>


        

        <div class="control-group">
          <!-- Button -->
          <div class="controls">
             <asp:Button class="btn btn-success btn-large btn-block" runat="server" Text="Calculate BMR" OnClick="btnCalculateClick" /> 
              <asp:Button class="btn btn-success btn-large btn-block" runat="server" Text="Calculate Daily Need" OnClick="btnCalculateDailyClick" />
            
          </div>
        </div>
      </fieldset>
    


      <div class="pull-right">
          
             
                 <asp:Label ID="lblgain1" runat="server" CssClass="label">Gain 0,45kg per week : </asp:Label><div class="progress progress-info"><div class="bar" style="text-align:left; padding-left:10px;" id="divGain1" runat="server"><asp:Label ID="gain1" runat="server" ForeColor="Black"></asp:Label></div></div>
                 <asp:Label ID="lblgain2" runat="server" CssClass="label">Gain 1kg per week : </asp:Label><div class="progress progress-warning"><div class="bar" style="text-align:left; padding-left:10px;" id="divGain2" runat="server"><asp:Label ID="gain2" runat="server" ForeColor="Black"></asp:Label></div></div>
                 <asp:Label runat="server" ID="lbllose1" CssClass="label">Lose 0,45kg per week :</asp:Label><div class="progress progress-success"><div class="bar" style="text-align:left; padding-left:10px;" id="divLose1" runat="server"><asp:Label ID="lose1" runat="server" ForeColor="Black"></asp:Label></div></div>
                 <asp:Label runat="server" CssClass="label" ID="lbllose2">Lose 1kg per week :</asp:Label><div class="progress progress-danger"><div class="bar" style="text-align:left; padding-left:10px;" id="divLose2" runat="server"><asp:Label ID="lose2" runat="server" ForeColor="Black"></asp:Label></div></div>
          
      </div>
      
     
  </section>
    
</asp:Content>

