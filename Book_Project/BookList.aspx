<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookList.aspx.cs" Inherits="Book_Project.BookList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            margin-top: 0px;
            margin-bottom: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="DataList1" runat="server" RepeatColumns="4" RepeatDirection="Horizontal" CellSpacing="-1" CssClass="auto-style2">
                <ItemTemplate>
                    <table class="auto-style1">
                        <tr>
                            <td>
                                <asp:ImageButton ID="ImageButton2" runat="server" CommandArgument='<%# Eval("categoryid") %>' CommandName="categoryselect" Height="196px" ImageUrl='<%# Eval("image") %>' OnCommand="ImageButton2_Command" Width="324px" />
                            </td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
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
