<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tenstudent.aspx.cs" Inherits="TestTen_3.tenstudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            学生账号，登录成功！<br />
&nbsp;&nbsp;&nbsp; 欢迎您，<asp:Label ID="Label1" runat="server" Text="user"></asp:Label>
            <br />
            <br />
            现在您可以为您的账户修改密码：<br />
&nbsp;&nbsp;&nbsp; 新密码：&nbsp; 
            <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp; 确认密码：<asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="确认" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="取消" />
            <br />
&nbsp;
        </div>
    </form>
</body>
</html>
