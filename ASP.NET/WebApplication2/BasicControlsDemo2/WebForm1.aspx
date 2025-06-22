<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="BasicControlsDemo2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 275px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label2" runat="server" Text="<b>This is Label</b>"></asp:Label>
            <br />
            <br />
            <asp:Literal ID="Literal1" runat="server" Text="&lt;b&gt;This is literal&lt;/b&gt;" Mode="Encode"></asp:Literal>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" OnClientClick="return confirm('Do u really want to submit the form?')" />
            <br />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
            <br />
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/wallpaperShankhnad.png" Width="166px" />
            <br />
            <br />
            <asp:Label ID="lblTime" runat="server" Text="DateTime"></asp:Label>
            <br />
            <br />
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            <br />
            <asp:Button ID="ButtonSave" runat="server" OnClick="Button2_Click" Text="Save" />
            <br />
        </div>
        
    </form>
</body>
</html>
