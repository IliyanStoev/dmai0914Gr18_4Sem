<%@ Page Title="" Language="C#" MasterPageFile="~/MpDefault.master" AutoEventWireup="true" CodeFile="404.aspx.cs" Inherits="_404" %>
<%@ MasterType VirtualPath="~/MpDefault.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <section id="error" class="container">
        <h1>404, Page not found</h1>
        <p>The Page you are looking for doesn't exist or an other error occurred.</p>
        <a class="btn btn-success" href="Home.aspx">GO BACK TO THE HOMEPAGE</a>
    </section>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

