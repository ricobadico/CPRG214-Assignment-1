<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Slips.aspx.cs" Inherits="CPRG214.Assignment1.App.Slips" %>

<%@ Register Src="~/Controls/SlipData.ascx" TagPrefix="uc1" TagName="SlipData" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h2>Available Slips</h2>
    <h3>Your application description page.</h3>
<p>&nbsp;</p>

 

    <asp:GridView ID="grdSlips" runat="server" Height="217px" Width="632px" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>

    <p>Use this area to provide additional information.</p>
</asp:Content>
