<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Doannhom.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    <link href="login.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
          <div class="login">
            <h2>Đăng ký </h2>
        
            <p>UserName</p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <p>Passwork</p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <p>Nhập lại Passwork</p>
              <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Đăng ký" OnClick="Button1_Click"  />
         
       
   
    </div>
    </form>
</body>
</html>
