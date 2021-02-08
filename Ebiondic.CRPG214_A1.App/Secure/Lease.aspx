<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lease.aspx.cs" Inherits="CPRG214.Assignment1.App.Secure.Lease" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="text-center">Lease a Slip</h2>
    <h3 class="text-center">Select an available slip to lease.</h3>
    <p class="text-center">
        Select a Dock:&nbsp;&nbsp;
        <asp:DropDownList ID="ddlDock" runat="server" Width="145px" AutoPostBack="True" OnSelectedIndexChanged="ddlDock_SelectedIndexChanged">
        </asp:DropDownList>
    </p>
    <asp:Panel ID="pnlStep2" runat="server">
        <asp:GridView ID="grdSlipsDock" runat="server" Height="217px" Width="300px" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="mx-sm-auto" OnRowDataBound="grdSlipsDock1_RowDataBound" OnRowCommand="grdSlipsDock_RowCommand">
             <RowStyle HorizontalAlign="Center" />
            <HeaderStyle HorizontalAlign="Center" /> 
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:ButtonField ButtonType="Button" HeaderText="Lease" ShowHeader="True" Text="Select" CommandName="Lease" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" CssClass="text-center" HorizontalAlign="Center" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" CssClass="text-center" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </asp:Panel>
    <p class="text-center">&nbsp;</p>

    

</asp:Content>
