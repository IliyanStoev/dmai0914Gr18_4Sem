<%@ Page Title="" Language="C#" MasterPageFile="~/MpDefault.master" AutoEventWireup="true" CodeFile="Shop.aspx.cs" Inherits="Shop" EnableEventValidation="false" %>

<%@ MasterType VirtualPath="~/MpDefault.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="title">
        <div class="container">
            <div class="row-fluid">
                <div class="span6">
                    <h1>Online Shop</h1>
                </div>
                <div class="span6">
                    <ul class="breadcrumb pull-right">
                        <li><a href="Home.aspx">Home</a> <span class="divider">/</span></li>
                        
                        <li class="active">Shop</li>
                    </ul>
                </div>
            </div>
        </div>
    </section>
    <div class="center">
        <h2>
            <label>Please Select Restaurant and Food Category</label></h2>
        <asp:DropDownList ID="resDrop" runat="server" AutoPostBack="true" OnSelectedIndexChanged="resDrop_SelectedIndexChanged" AppendDataBoundItems="true">
            <asp:ListItem>Please Select Restaurant</asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="foodGroupDd" runat="server" AutoPostBack="true" OnSelectedIndexChanged="foodGroupDd_SelectedIndexChanged" AppendDataBoundItems="true" Enabled="false">
            <asp:ListItem>Please Select Food Category</asp:ListItem>
            <asp:ListItem>Meals</asp:ListItem>
            <asp:ListItem>Salads</asp:ListItem>
            <asp:ListItem>Drinks</asp:ListItem>
        </asp:DropDownList>
    </div>


        <div>
        <asp:GridView ID="GridView1" runat="server" CssClass="myGridClass" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowCommand="GridView1_RowCommand" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField HeaderText="Id" DataField="id">
                 </asp:BoundField>
                <asp:BoundField HeaderText="Name" DataField="name">
                </asp:BoundField>
                <asp:BoundField HeaderText="Protein" DataField="protein" />
                <asp:BoundField HeaderText="Carbs" DataField="carbs" />
                <asp:BoundField HeaderText="Fat" DataField="fat" />
                <asp:BoundField HeaderText="Content" DataField="content" />
                <asp:BoundField HeaderText="Total Calories" DataField="totalCalories" />
                <asp:BoundField HeaderText="Price" DataField="price" />
                <asp:TemplateField HeaderText="Image">
                    <ItemTemplate>
                        <asp:Image ID="myImage" runat="server" Height="70px" Width="70px"
                            ImageUrl='<%#"data:Image/png;base64," + Convert.ToBase64String(((System.Data.Linq.Binary)Eval("photo")).ToArray()) %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:DropDownList runat="server" ID="quantDd">
                            <asp:ListItem Value="1"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>


                <asp:ButtonField ButtonType="Button" ControlStyle-CssClass="btn btn-success" Text="Add To Cart" CommandName="Add To Cart" />


            </Columns>
        </asp:GridView>
   </div>

    <div>
        <p></p>
        <asp:GridView ID="GridView2" CssClass="myGridClass" runat="server" OnRowCommand="GridView2_RowCommand" AutoGenerateColumns="false" ShowFooter="true" FooterStyle-CssClass="myFooterClass" DataKeyNames="id, prodId">
            <Columns>
                <asp:BoundField HeaderText="OrderLineId" DataField="id" Visible="false"  />
                <asp:BoundField HeaderText="Product Id" DataField="prodId" Visible="false" />
                <asp:BoundField HeaderText="Product Name"/>
                <asp:BoundField HeaderText="Protein"/>
                <asp:BoundField HeaderText="Carbohydrates"/>
                <asp:BoundField HeaderText="Fat"/>
                <asp:BoundField HeaderText="Product Calories"/>
                <asp:BoundField HeaderText="Price"/>
                <asp:BoundField HeaderText="Quantity" DataField="quantity"/>


                <asp:ButtonField ButtonType="Button" ControlStyle-CssClass="btn btn-success" Text="Remove" CommandName="Remove" />
            </Columns>
        </asp:GridView>
    </div>


    <div class="center">
        <asp:Button CssClass="center: btn btn-success btn-large" runat="server" ID="createOrderBtn" OnClick="createOrderBtn_Click" Text="Create" />
        <input type="text" runat="server" id="ordAddress" placeholder="Delivery Address" required="required" /></>
        <asp:CheckBox runat="server" AutoPostBack="true" CausesValidation="true" ID="ordAddressCheck" OnCheckedChanged="ordAddressCheck_CheckedChanged" />
        <label class="label">Use registered Address</label>
    </div>

</asp:Content>


