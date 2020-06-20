<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="sanpham.aspx.cs" Inherits="Doannhom.sanpham" %>

<%@ Register Assembly="CollectionPager" Namespace="SiteUtils" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server"  CellPadding="11"  RepeatColumns="4">
        <ItemStyle Width="25%" />
        <ItemTemplate>
            <asp:Image  ID="Image1" ImageUrl=' <%#"~/images/" +Eval("hinh") %>' runat="server" CssClass="image" />
            <br />
            <asp:Label ID="Label1" runat="server" Text='<%# Eval("tenhang") %>' Font-Size="15px"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text='<%# Eval("gia","{0:0,0}") %>' Font-Size="15px"></asp:Label>
            <asp:LinkButton ID="LinkButton2"  CommandArgument='<%# Eval("mahang") %>' runat="server" OnClick="LinkButton2_Click" Font-Size="15px">Chi Tiết Sản Phẩm</asp:LinkButton>
        </ItemTemplate>
    </asp:DataList>
    <cc1:CollectionPager ID="CollectionPager1" ResultsLocation="Bottom" runat="server"></cc1:CollectionPager>
</asp:Content>
