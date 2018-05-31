<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RoomAdmin.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
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
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong><span class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <div>
                <p style="margin-left: 40px">
                    <strong style="margin-left: 240px">酒店管理系统 </strong>
                </p>
            </div>
            </span></strong>
            <div style="width: 367px; height: 232px; margin-left: 255px; margin-top: 0px; background-color: #99CCFF">
                <br />
                <br />
&nbsp;&nbsp;&nbsp; 用户名:
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <br />
&nbsp;&nbsp;&nbsp; 密&nbsp; 码：<asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <br />
&nbsp;&nbsp;&nbsp; 角&nbsp; 色：<asp:RadioButton ID="RadioButton1" runat="server" Checked="True" GroupName="adminoryy" Text="管理员" />
&nbsp;
                <asp:RadioButton ID="RadioButton2" runat="server" GroupName="adminoryy" Text="营业员" />
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="登录" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="取消" />
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
        </div>
    </form>
</body>
</html>
