<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="Book_Project.Orders" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="orderid" HeaderText="Order ID" />
                    <asp:BoundField DataField="ordertotal" HeaderText="Total Amount" />
                    <asp:BoundField DataField="orderaddress" HeaderText="Delivery Address" />
                    <asp:BoundField DataField="orderdate" HeaderText="Order Date" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
