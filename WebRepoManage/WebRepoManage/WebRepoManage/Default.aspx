<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebRepoManage.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: 微软雅黑;
            font-size: xx-large;
            margin-left: 280px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color: #66CCFF">
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <div>
                <p class="auto-style1">
                    <strong>&nbsp;&nbsp;&nbsp; 仓库管理系统</strong></p>
            </div>
            <br />
            <div style="width: 414px; height: 251px; margin-left: 328px; background-color: #99CCFF">
                <br />
                <br />
&nbsp;&nbsp;&nbsp; 用户名：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <br />
&nbsp;&nbsp;&nbsp; 密&nbsp;&nbsp; 码：<asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <br />
&nbsp;&nbsp;&nbsp; 角&nbsp;&nbsp; 色：<asp:RadioButton ID="RadioButton1" runat="server" Checked="True" Text="管理员" GroupName="gender" />
                <asp:RadioButton ID="RadioButton2" runat="server" Text="员工" GroupName="gender" />
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="登录" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="取消" OnClick="Button2_Click" />
            </div>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
