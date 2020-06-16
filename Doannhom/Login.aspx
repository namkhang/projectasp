<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Doannhom.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="login.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="login">
        <h2>Đăng nhập </h2>
        
            <p>UserName</p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <p>Passwork</p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Đăng nhập" OnClick="Button1_Click" />
         
            <a href="#">Forget Passwork</a>
   
    </div>
    </form>
</body>
</html>
