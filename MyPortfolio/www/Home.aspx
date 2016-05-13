<%@ Page Title="" Language="C#" MasterPageFile="~/MpDefault.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>
<%@ MasterType VirtualPath="~/MpDefault.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="center">
   <asp:Label runat="server" CssClass="center"><h2>Most Ordered Product</h2></asp:Label>
    
    <h2><asp:Label runat="server"  ID="lblMostName"></asp:Label></h2> <br />
    <h2><asp:Label runat="server" ID="lblMostOrd"></asp:Label></h2> <br />
    <asp:Image runat="server" ID="prodImage"/>
        <h2><asp:Label runat="server" ID="lblRest"></asp:Label></h2> <br />
        </div>
    
</asp:Content>

