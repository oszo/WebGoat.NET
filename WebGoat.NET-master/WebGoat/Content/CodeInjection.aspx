<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Master-Pages/Site.Master" ValidateRequest="false" AutoEventWireup="true" CodeBehind="CodeInjection.aspx.cs" Inherits="OWASP.WebGoat.NET.Content.CodeInjection" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContentPlaceHolder" runat="server">
    Sharing Space
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContentPlaceholder" runat="server">
    <p>Share your story to all of us.</p>

    <p><asp:TextBox ID="txtBoxMsgCi" runat="server" TextMode="MultiLine" Width="400px" Height="100px" /></p>
    
    <p><asp:Button ID="btnCi" runat="server" onclick="btnCi_Click" Text="Share" SkinID="Button"/></p>
    <p>Demo Shareing Page:</p>
    <iframe src="<%= Page.ResolveUrl("~/share_article/page.aspx") %>" width="500" height="500"></iframe>
</asp:Content>
