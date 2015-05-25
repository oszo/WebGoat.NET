<%@ Page Title="" Language="C#" ValidateRequest="false" MasterPageFile="~/Resources/Master-Pages/Site.Master" AutoEventWireup="true" CodeBehind="CSRFDemo.aspx.cs" Inherits="OWASP.WebGoat.NET.CSRFDemo" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContentPlaceholder" runat="server">
    <h1>Salary Management</h1>
    <p>Hi, Manager.</p>
    <p><asp:Button ID="btnReset" runat="server" onclick="btnReset_Click" Text="Reset" SkinID="Button"/></p>
    
    Employee Name: <asp:TextBox ID="emId" runat="server"/><br />
    Salary Increase: <asp:TextBox ID="slIncrease" runat="server"/><br />
    <asp:Button ID="buttonIncrease" runat="server" onclick="buttonIncrease_Click" Text="Increase" SkinID="Button"/><br />

    <h3>Salary Details</h3>
    <asp:Literal runat="server" EnableViewState="False" ID="labelStatus"></asp:Literal>
</asp:Content>
