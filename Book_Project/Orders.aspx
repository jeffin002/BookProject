<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="Book_Project.Orders" %>

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
