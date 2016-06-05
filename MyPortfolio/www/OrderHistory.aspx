<%@ Page Title="" Language="C#" MasterPageFile="~/MpDefault.master" AutoEventWireup="true" CodeFile="OrderHistory.aspx.cs" Inherits="OrderHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
              
            


                


            </Columns>
        </asp:GridView>
    </div>

</asp:Content>

