<%@ Page Language="C#" MasterPageFile="~/Resources/Master-Pages/Site.Master" ValidateRequest="false" AutoEventWireup="true" CodeBehind="WeakAuthenCookie.aspx.cs" Inherits="OWASP.WebGoat.NET.Content.WeakAuthenCookie" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContentPlaceholder" runat="server">
    <h1>Salary System</h1>
    <asp:Literal runat="server" EnableViewState="False" ID="labelName"></asp:Literal><br />
    <% 
        if (Request.Cookies["salary_authen"] == null)
        {
    %>
            <p>Employee name:<br/><asp:TextBox ID="txtBoxUsername" runat="server"/></p>
            <p>Password:<br/><asp:TextBox ID="txtBoxPassword" runat="server" TextMode="Password"/><i>Default: 3 Digit of employee name.</i></p>
            <p><asp:Button ID="btnLogin" runat="server" onclick="btnLogin_Click" Text="Login" SkinID="Button"/></p>
    <%
        }
        else 
        { 
    %>
                <asp:Button ID="btnLogout" runat="server" onclick="btnLogout_Click" Text="Log Out" SkinID="Button"/>
    <%
        }
    %>
    <p>
        <h3>Employee Infomation</h3>
        <table style="width:100%">
          <tr>
            <td>
                <p><asp:Button ID="btnEm1" runat="server" onclick="btnEm1_Click" Text="John (Manager)" SkinID="Button"/></p>
                <p><asp:Button ID="btnEm2" runat="server" onclick="btnEm2_Click" Text="Alice" SkinID="Button"/></p>
                <p><asp:Button ID="btnEm3" runat="server" onclick="btnEm3_Click" Text="Morgan" SkinID="Button"/></p>
            </td>
            <td>
                <asp:Literal runat="server" EnableViewState="False" ID="labelEmInfo"></asp:Literal>
            </td>
          </tr>
        </table>
    </p>
    <asp:Literal runat="server" EnableViewState="False" ID="labelStatus"></asp:Literal>
</asp:Content>
