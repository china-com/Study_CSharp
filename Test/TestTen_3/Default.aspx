<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestTen_3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:350px;background:#0080D5">
            <asp:Label ID="Label1" runat="server" Text="用户登录"></asp:Label>
        </div>
    <div style="width:350px;background:#9999FF">
        <br />
        <br />
        &nbsp; <asp:Label ID="Label2" runat="server" Text="用户名"></asp:Label>
        &nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="165px"></asp:TextBox>
        <br />
        <br />
&nbsp;
        <asp:Label ID="Label3" runat="server" Text="身份类型"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" style="margin-left: 0px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>学生</asp:ListItem>
            <asp:ListItem>教师</asp:ListItem>
            <asp:ListItem>管理员</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
&nbsp;
        <asp:Label ID="Label4" runat="server" Text="密码"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Width="172px" TextMode="Password"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="登录" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="注册" OnClick="Button2_Click" />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="    "></asp:Label>
        <br />
    </div>
    </form>
    </body>
</html>
