<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestTen_2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            代码&nbsp; 
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="查询" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </p>
    </form>
</body>
</html>
