<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CalendarUserControl.ascx.cs" Inherits="UserControlDemo.CalendarUserControl" %>
<asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" Height="220px" NextPrevFormat="FullMonth" OnSelectionChanged="Calendar1_SelectionChanged" TitleFormat="Month" Width="400px">
    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" ForeColor="#333333" Height="10pt" />
    <DayStyle Width="14%" />
    <NextPrevStyle Font-Size="8pt" ForeColor="White" />
    <OtherMonthDayStyle ForeColor="#999999" />
    <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
    <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#333333" Width="1%" />
    <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" />
    <TodayDayStyle BackColor="#CCCC99" />
</asp:Calendar>
<p>
    &nbsp;</p>
<asp:TextBox ID="txtDate" runat="server" Width="358px"></asp:TextBox>
&nbsp;<asp:ImageButton ID="btnDate" runat="server" OnClick="ImageButton1_Click" Width="22px" />

