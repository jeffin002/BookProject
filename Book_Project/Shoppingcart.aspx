<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Shoppingcart.aspx.cs" Inherits="Book_Project.Shoppingcart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 52px;
        }
        .auto-style3 {
            width: 132px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label1" runat="server" Text="Total Items"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label3" runat="server" Text="Total Price"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="BookName" HeaderText="Name" />
                    <asp:BoundField DataField="BookDescription" HeaderText="Description" />
                    <asp:ImageField DataImageUrlField="BookImage" HeaderText="Image">
                        <ControlStyle Height="200px" Width="150px" />
                    </asp:ImageField>
                    <asp:BoundField DataField="AuthorName" HeaderText="Author" />
                    <asp:BoundField DataField="BookUnitPrice" HeaderText="Unit Price" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                    <asp:BoundField DataField="updateddate" HeaderText="Added Date" />
                    <asp:TemplateField HeaderText="Actions">
                        <ItemTemplate>
                            <table class="auto-style1">
                                <tr>
                                    <td class="auto-style2">
                                        <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("shoppingcartid") %>' OnCommand="LinkButton1_Command">Delete</asp:LinkButton>
                                    </td>
                                    <td>
                                        <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("shoppingcartid") %>'>Edit</asp:LinkButton>
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
