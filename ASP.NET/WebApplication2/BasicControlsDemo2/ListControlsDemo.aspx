<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListControlsDemo.aspx.cs" Inherits="BasicControlsDemo2.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Select Category"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>Books</asp:ListItem>
                <asp:ListItem>Sports</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Select Subcategory"></asp:Label>
            <br />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" Height="16px" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged" Width="101px">
            </asp:CheckBoxList>
            <br />
            <asp:Button ID="ButtonDisplayList" runat="server" OnClick="ButtonDisplayList_Click" Text="Display List" />
            <br />
            <br />
            <asp:Label ID="LabelCategory" runat="server" Font-Bold="True"></asp:Label>
            <asp:BulletedList ID="BulletedList1" runat="server">
            </asp:BulletedList>
            <br />
        </div>
    </form>
</body>
</html>
