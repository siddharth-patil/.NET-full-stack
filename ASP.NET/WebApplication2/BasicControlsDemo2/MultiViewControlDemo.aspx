<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MultiViewControlDemo.aspx.cs" Inherits="BasicControlsDemo2.MultiViewControlDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 403px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:MultiView ID="PersonDetails" runat="server">
                <asp:View ID="PersonalDetails" runat="server">
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style2">Add Personal Details</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style2">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style2">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style2">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </asp:View>

                <asp:View ID="ProfessionalDetails" runat="server">
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style2">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style2">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style2">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style2">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </asp:View>

                <asp:View ID="Summary" runat="server"></asp:View>
                <br />
            </asp:MultiView>
        </div>
    </form>
</body>
</html>
