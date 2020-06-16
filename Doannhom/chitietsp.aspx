<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="chitietsp.aspx.cs" Inherits="Doannhom.chitietsp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            
            <asp:Image ID="Image1"  ImageUrl=' <%#"~/images/" +Eval("hinh") %>' runat="server" />
            <br />
            <asp:Label ID="Label1" runat="server"  Text='<%# Eval("tenhang") %>'></asp:Label>
            <asp:Label ID="Label2" runat="server"  Text='<%# Eval("size") %>'></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server"  Text='<%# Eval("mota") %>'></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server"  Text='<%# Eval("gia","{0:0,0}") %>'></asp:Label>
            <br />
            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Giỏ hàng</asp:LinkButton>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Số luọng"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Size"></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem>S</asp:ListItem>
                <asp:ListItem>L</asp:ListItem>
                <asp:ListItem>XL</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Button ID="Button1"  CommandArgument='<%# Eval("mahang") %>' runat="server" OnClick="Button1_Click" Text="Mua Hàng" />
            
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
