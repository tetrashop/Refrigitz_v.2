 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormRefregitz.aspx.cs" Inherits="WebApplicationRefregitz.WebFormRefregitz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
    <div>
    
        <asp:Image ID="Image2" runat="server" Height="504px" Width="494px" OnLoad="Image2_Load" />
        <br />
    
    </div>
        <asp:Button ID="Button1" runat="server" Text="Blitz Begin" />
        <asp:Button ID="Button2" runat="server" Text="Previouse" />
        <asp:Button ID="Button3" runat="server" Text="Next" />
    </form>
    <form id="form1" runat="server">
    </form>
    <p style="direction: ltr">
        &nbsp;</p>
</body>
</html>
