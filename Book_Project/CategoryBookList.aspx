<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CategoryBookList.aspx.cs" Inherits="Book_Project.CategoryBookList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 87px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="DataList1" runat="server" RepeatColumns="5">
                <ItemTemplate>
                    <table class="auto-style1">
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("BookName") %>'></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Image ID="Image1" runat="server" Height="212px" ImageUrl='<%# Eval("BookImage") %>' Width="230px" />
                            </td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("BookDescription") %>'></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <table class="auto-style1">
                                    <tr>
                                        <td class="auto-style3">&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style3">
                                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("BookUnitPrice") %>'></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style3">&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style3">
                                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("PublishedDate") %>'></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style3">&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style3">
                                            <asp:Label ID="Label5" runat="server" Text='<%# Eval("AuthorName") %>'></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style3">&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style3">
                                            <asp:Button ID="Button1" runat="server" BorderWidth="5px" CommandArgument='<%# Eval("BookId") %>' ForeColor="Red" OnCommand="Button1_Command" Text="Add To Cart" />
                                        </td>
                                        <td>
                                            <asp:Label ID="Label6" runat="server" Text="Label" Visible="False"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
