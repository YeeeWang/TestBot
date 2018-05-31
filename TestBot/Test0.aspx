<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test0.aspx.cs" Inherits="TestBot.Test0" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Height="45px" OnClick="Button1_Click" Text="發送文字" Width="124px" />
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button2" runat="server" Height="45px" OnClick="Button2_Click" Text="發送貼圖" Width="124px" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button3" runat="server" Height="45px" OnClick="Button3_Click" Text="發送圖片" Width="124px" />
        </p>
    </form>
</body>
</html>
