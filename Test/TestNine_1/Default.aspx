﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestNine_1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            请输入名字：
         
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>&nbsp
            <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" /><br />
            <br />
            请输入年龄：
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

        </div>
    </form>
</body>
</html>
