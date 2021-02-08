<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SlipData.ascx.cs" Inherits="CPRG214.Assignment1.App.Controls.SlipData" %>
<asp:Panel ID="Panel1" runat="server" Height="130px" Width="130px" BorderStyle="Solid" BackColor="#E1FFFF" BorderColor="#3399FF">
    <div class="d-flex flex-column align-items-center boat-bg">
        <asp:Label ID="lblID" runat="server" Text="ID #" Font-Bold="True" Font-Size="X-Large"></asp:Label>
        <asp:Label ID="lblSize" runat="server" Text="Size: ###" Font-Bold="True" ToolTip="Width x Length, in meters."></asp:Label>
        <asp:Label ID="lblWater" runat="server" Text="Water" Font-Bold="True"></asp:Label>
        <asp:Label ID="lblElectric" runat="server" Text="Electric" Font-Bold="True"></asp:Label>
    </div>
</asp:Panel>

