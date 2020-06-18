<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="sanpham.aspx.cs" Inherits="Doannhom.sanpham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server"  RepeatColumns="3">
        <ItemTemplate>
            <asp:Image ID="Image1" ImageUrl=' <%#"~/images/" +Eval("hinh") %>' runat="server" />
            <br />
            <asp:Label ID="Label1" runat="server" Text='<%# Eval("tenhang") %>'></asp:Label>
            <asp:Label ID="Label2" runat="server"  Text='<%# Eval("size") %>'></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text='<%# Eval("gia","{0:0,0}") %>'></asp:Label>
            <asp:LinkButton ID="LinkButton2"  CommandArgument='<%# Eval("mahang") %>' runat="server" OnClick="LinkButton2_Click">Chi Tiết Sản Phẩm</asp:LinkButton>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
