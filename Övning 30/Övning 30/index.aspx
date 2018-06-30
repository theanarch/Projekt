<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Övning_30.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 137px;
        }
        .auto-style3 {
            width: 138px;
        }
        .auto-style4 {
            width: 138px;
            height: 26px;
        }
        .auto-style5 {
            width: 137px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
        .auto-style7 {
            margin-left: 42px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBoxContacts" runat="server" Height="400px" Width="300px" AutoPostBack="True" OnSelectedIndexChanged="ListBoxContacts_SelectedIndexChanged"></asp:ListBox>

            <table style="width: 100%;">
                <tr>
                    <td class="auto-style3">Firstname</td>
                    <td class="auto-style2">Lastname</td>
                    <td>SSN</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBoxFirstname" runat="server"></asp:TextBox></td>
                    <td class="auto-style5"><asp:TextBox ID="TextBoxLastname" runat="server" style="margin-left: 0px"></asp:TextBox></td>
                    <td class="auto-style6"><asp:TextBox ID="TextBoxSSN" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>

        <div>
            <asp:Button ID="ButtonAdd" runat="server" CssClass="auto-style7" OnClick="ButtonAdd_Click" Text="Add" Width="108px" />
            <asp:Button ID="ButtonRemove" runat="server" CssClass="auto-style7" OnClick="ButtonRemove_Click" Text="Remove" Width="108px" />
            <asp:Button ID="ButtonUpdate" runat="server" CssClass="auto-style7" OnClick="ButtonUpdate_Click" Text="Update" Width="108px" />
        </div>

    </form>
</body>
</html>
