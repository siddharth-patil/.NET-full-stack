<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="FullPageCachingDemo.WebForm1" %>
<%@ OutputCache Location="Server" Duration="60" VaryByControl="DropDownList1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTime" runat="server"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>Book</asp:ListItem>
                <asp:ListItem>Technology</asp:ListItem>
                <asp:ListItem>Sports</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
&nbsp; You Selected :
            <asp:Label ID="lblOption" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
