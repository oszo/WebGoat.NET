<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadAcceptAttrib.aspx.cs" Inherits="OWASP.WebGoat.NET.Content.UploadAcceptAttrib" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <asp:Label ID="labelUpload" runat="server" Visible="false"></asp:Label>
    <form id="form1" enctype="multipart/form-data" runat="server">
        <input name="uploadedFile" id="uploadedFile" type="file" accept=".jpg,.gif" /><br />
        <asp:Button runat="server" ID="btnUpload" OnClick="btnUploadClick" Text="Upload" />
    </form>
</body>
</html>