<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Master-Pages/Site.Master" AutoEventWireup="true" CodeBehind="CommandInjection.aspx.cs" Inherits="OWASP.WebGoat.NET.CommandInjection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContentPlaceholder" runat="server">
    <p>Destination IP to ping</p>

    <p><asp:TextBox ID="txtBoxMsgCmdi" runat="server" /></p>
    
    <p><asp:Button ID="btnCmdi" runat="server" onclick="btnCmdi_Click" Text="Ping" SkinID="Button"/></p>
    <p>Result: <asp:Label ID="lblResultCmdi" runat="server" /></p>
</asp:Content>
