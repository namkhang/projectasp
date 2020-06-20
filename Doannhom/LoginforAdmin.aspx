<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginforAdmin.aspx.cs" Inherits="Doannhom.LoginforAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login for Admin</title>
    <link href="login.css" rel="stylesheet" />
</head>
<body style="background-image:url(thiennhien.jpg)">
    <form id="form1" runat="server">
        <div class="login">
        <h2 >Đăng nhập </h2>
        
            <p>Admin</p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <p>Passwork</p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Đăng nhập " OnClick="Button1_Click" />
         
            <a href="#">Forget Passwork</a>
   
    </div>
    </form>
</body>
</html>
