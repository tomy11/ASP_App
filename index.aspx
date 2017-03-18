<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ASP_Session.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="ชื่อ"></asp:Label>
        <asp:TextBox ID="txtfirstname" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="สกุล"></asp:Label>
        <asp:TextBox ID="txtlastname" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btsend" runat="server" OnClick="btsend_Click" Text="send" />
    
    </div>
    </form>
</body>
</html>
