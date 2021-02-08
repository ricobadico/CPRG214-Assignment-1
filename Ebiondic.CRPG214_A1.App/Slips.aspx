<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Slips.aspx.cs" Inherits="CPRG214.Assignment1.App.Slips" %>

<%@ Register Src="~/Controls/SlipData.ascx" TagPrefix="uc1" TagName="SlipData" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h2 class="text-center">Available Slips</h2>
    <h3>Below are a list of slips currently available for leasing, along with their details.</h3>

 <div class="container"></div>
    <div class="row">
        <div class="col-sm-4">
            <h5 class="text-center">Dock 1</h5>
            <asp:GridView ID="grdSlipsDock1" runat="server" Height="217px" Width="300px" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="mx-sm-auto" OnRowDataBound="grdSlipsDock1_RowDataBound">
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
        </div>
        <div class="col-sm-4">
            <h5 class="text-center">Dock 2</h5>
            <asp:GridView ID="grdSlipsDock2" runat="server" Height="217px" Width="300px" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="mx-sm-auto" OnRowDataBound="grdSlipsDock2_RowDataBound">
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
        </div>
        <div class="col-sm-4">
            <h5 class="text-center">Dock 3</h5>
            <asp:GridView ID="grdSlipsDock3" runat="server" Height="217px" Width="300px" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="mx-sm-auto" OnRowDataBound="grdSlipsDock3_RowDataBound">
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
        </div>
    </div>

    

     

     

    <p>Use this area to provide additional information.</p>
</asp:Content>
