<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tenadmin.aspx.cs" Inherits="TestTen_3.tenadmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        管理员账户，登录成功！<br />
&nbsp;&nbsp;&nbsp; 欢迎您！<asp:Label ID="Label1" runat="server" Text="user"></asp:Label>
        <br />
        <br />
        <br />
        <div>

        <asp:Button ID="Button1" runat="server" Height="32px" OnClick="Button1_Click" Text="查询所有学生" Width="154px" />

        </div>
        <br />
        删除学生用户：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="height: 27px" Text="确定删除" />
        <br />
        <br />
    </form>
</body>
</html>
