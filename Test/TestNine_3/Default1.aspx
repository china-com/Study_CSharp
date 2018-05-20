<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default1.aspx.cs" Inherits="TestNine_3.Default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            输出传递的变量值：
         
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;
            <asp:Button ID="Button2" runat="server" Text="提交" OnClick="Button2_Click" />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
