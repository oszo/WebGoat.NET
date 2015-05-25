<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadJs.aspx.cs" Inherits="OWASP.WebGoat.NET.Content.UploadJs"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function checkFile() {
            var fileElement = document.getElementById("uploadedFile");
            var fileExtension = "";
            if (fileElement.value.lastIndexOf(".") > 0) {
                fileExtension = fileElement.value.substring(fileElement.value.lastIndexOf(".") + 1, fileElement.value.length);
            }
            if (fileExtension == "gif") {
                return true;
            }
            else {
                alert("You must select a GIF file for upload");
                return false;
            }
        }
    </script>
</head>
<body>
    <asp:Label ID="labelUpload" runat="server" Visible="false"></asp:Label>
    <form id="form1" enctype="multipart/form-data" onsubmit="return checkFile();" runat="server">
        <input name="uploadedFile" id="uploadedFile" type="file" /><br />
        <asp:Button runat="server" ID="btnUpload" OnClick="btnUploadClick" Text="Upload" />
    </form>
</body>
</html>
