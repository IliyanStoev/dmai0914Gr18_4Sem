<%@ Page Title="" Language="C#" MasterPageFile="~/MpDefault.master" AutoEventWireup="true" CodeFile="OrderHistory.aspx.cs" Inherits="OrderHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section class="title">
    <div class="container">
      <div class="row-fluid">
        <div class="span6">
          <h1>Orders History</h1>
        </div>
        <div class="span6">
          <ul class="breadcrumb pull-right">
            <li><a href="Home.aspx">Home</a> <span class="divider">/</span></li>
            <li><a href="UpdateUser.aspx">User Profile</a> <span class="divider">/</span></li>
            
            <li class="active">Orders History</li>
          </ul>
        </div>
      </div>
    </div>
  </section>
    <div class="center">
     <h2><asp:Label runat="server" ID="lblNoOrd" Visible="false">You have no orders so far</asp:Label></h2>
   
        </div>
    
    <div class="container center">
        <asp:GridView ID="GridView1" CssClass="myGridClass2" HorizontalAlign="left" runat="server" DataKeyNames="Id" OnRowCommand="GridView1_RowCommand" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField HeaderText="Id" DataField="id" Visible="false">
                    
                </asp:BoundField>
                <asp:BoundField HeaderText="Order Date" DataField="orderDate">
                    
                </asp:BoundField>
                <asp:BoundField HeaderText="Total Calories" DataField="totalCals" />
                <asp:BoundField HeaderText="Total" DataField="total" /> 
            


                <asp:ButtonField ButtonType="Button" Text="View Details" ControlStyle-CssClass="btn btn-info" CommandName="ViewDetails" />


            </Columns>
        </asp:GridView>
        
       
        <asp:GridView ID="GridView2" CssClass="myGridClass2" HorizontalAlign="right" runat="server" AutoGenerateColumns="False">
            <Columns>
                
                <asp:BoundField HeaderText="Product Name" DataField="name">
                   
                </asp:BoundField>
                <asp:BoundField HeaderText="Product Fat" DataField="fat">
                    
                </asp:BoundField>
                <asp:BoundField HeaderText="Product Protein" DataField="protein">
                   
                </asp:BoundField>
                <asp:BoundField HeaderText="Product Total Calories" DataField="totalCalories">
                  
                </asp:BoundField>
                <asp:BoundField  HeaderText="Product Quantity" DataField="quantity">
                   
                    </asp:BoundField>
              
            


               


            </Columns>
        </asp:GridView>
     </div>
    
    
    

</asp:Content>

