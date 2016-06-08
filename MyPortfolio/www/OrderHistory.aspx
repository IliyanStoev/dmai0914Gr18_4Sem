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
    
        <asp:GridView ID="GridView1" CellPadding="6" runat="server" GridLines="None" DataKeyNames="Id" OnRowCommand="GridView1_RowCommand" Width="352px" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField HeaderText="Id" DataField="id" Visible="false">
                    <ItemStyle Font-Italic="True" />
                </asp:BoundField>
                <asp:BoundField HeaderText="Order Date" DataField="orderDate">
                    <ItemStyle Font-Italic="True" />
                </asp:BoundField>
                <asp:BoundField HeaderText="Total Calories" DataField="totalCals" />
                <asp:BoundField HeaderText="Total" DataField="total" />
            


                <asp:ButtonField ButtonType="Button" Text="View Details" CommandName="ViewDetails" />


            </Columns>
        </asp:GridView>
        </div>
        <div>
        <asp:GridView ID="GridView2" CellPadding="6" runat="server" GridLines="None" Width="352px" AutoGenerateColumns="False">
            <Columns>
                
                <asp:BoundField HeaderText="Product Name" DataField="name">
                    <ItemStyle Font-Italic="True" />
                </asp:BoundField>
                <asp:BoundField HeaderText="Product Fat" DataField="fat">
                    <ItemStyle Font-Italic="True" />
                </asp:BoundField>
                <asp:BoundField HeaderText="Product Protein" DataField="protein">
                    <ItemStyle Font-Italic="True" />
                </asp:BoundField>
                <asp:BoundField HeaderText="Product Total Calories" DataField="totalCalories">
                    <ItemStyle Font-Italic="True" />
                </asp:BoundField>
                <asp:BoundField  HeaderText="Product Quantity" DataField="quantity">
                    <ItemStyle Font-Italic="true"/>
                    </asp:BoundField>
              
            


                


            </Columns>
        </asp:GridView>
    </div>

</asp:Content>

