<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Slips.aspx.cs" Inherits="CPRG214.Assignment1.App.Slips" %>

<%@ Register Src="~/Controls/SlipData.ascx" TagPrefix="uc1" TagName="SlipData" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h2 class="text-center">Available Slips</h2>
    <br />
    <h4 class="text-center">Below are a list of slips currently available for leasing, along with their details.</h4>
    <br />
    <p class="text-center" style="font-size:large">Select a Dock:
        <asp:DropDownList ID="ddlDock" runat="server" Width="145px" AutoPostBack="True" OnSelectedIndexChanged="ddlDock_SelectedIndexChanged">
        </asp:DropDownList>
    </p>

     <asp:Panel ID="slipContainer1" runat="server" CssClass="d-flex flex-wrap"></asp:Panel>

</asp:Content>
