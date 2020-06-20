<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="giohang.aspx.cs" Inherits="Doannhom.giohang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="mahang" HeaderText="Mã hàng" />
                    <asp:BoundField DataField="tenhang" HeaderText="Tên hàng" />
                    <asp:BoundField DataField="gia" HeaderText="Giá" />
                    <asp:BoundField DataField="soluong" HeaderText="Số lượng" />
                    <asp:BoundField DataField="size" HeaderText="Size" />
                    <asp:BoundField DataField="thanhtien" HeaderText="Thành tiền" SortExpression="thanhtien" />
                    <asp:BoundField DataField="tendangnhap" HeaderText="Tên người mua" />
                </Columns>
            </asp:GridView>
            <asp:Label ID="Label1" runat="server" Text='<%# Eval("thanhtien") %>'></asp:Label>
        </div>
    </form>
</body>
</html>
