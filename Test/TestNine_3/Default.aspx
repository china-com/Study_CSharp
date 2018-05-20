<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestNine_3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            用户名：
         
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="登录" OnClick="Button1_Click" />
&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="退出" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
