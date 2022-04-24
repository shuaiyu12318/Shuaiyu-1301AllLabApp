<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowListControls.aspx.cs" Inherits="LabAss4.ShowListControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><h1>ListBox</h1></div>
        <asp:ListBox ID="ListBox1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Username" DataValueField="Username"></asp:ListBox>
        <div><h1>DropDownList</h1></div>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Username" DataValueField="Username"></asp:DropDownList>
        <div><h1>BulletedList</h1></div>
        <asp:BulletedList ID="BulletedList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Username" DataValueField="Username"></asp:BulletedList>
        <div><h1>CheckBoxList</h1></div>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Username" DataValueField="Username"></asp:CheckBoxList>
        <div><h1>RadioButtonList</h1></div>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Username" DataValueField="Username"></asp:RadioButtonList><asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SimpleDatabaseConnectionString %>" SelectCommand="SELECT [Username], [password] FROM [Logon]"></asp:SqlDataSource>
        
    </form>
</body>
</html>
