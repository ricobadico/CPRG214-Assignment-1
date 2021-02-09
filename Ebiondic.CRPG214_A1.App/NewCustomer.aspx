<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewCustomer.aspx.cs" Inherits="CPRG214_Assignment1.App.NewCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="d-flex flex-column justify-content-center align-items-center">
        <br />
    <h2 class="m4 text-center">New Customer</h2>
        <br />
    <div class="col-md-6 justify-content-end">
        <table class="table">
            <tr>
                <td class="text-primary text-center">First Name:</td>
                <td style="width:186px">
                    <asp:TextBox ID="uxFName" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="uxFName" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="text-primary text-center">Last Name:</td>
                <td>
                    <asp:TextBox ID="uxLName" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="uxLName" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="text-primary text-center">Phone:</td>
                <td>
                    <asp:TextBox ID="uxPhone" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="uxPhone" ForeColor="Red"></asp:RequiredFieldValidator><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Must be ###-###-####" ControlToValidate="uxPhone" ForeColor="Red" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="text-primary text-center">City:</td>
                <td>
                    <asp:TextBox ID="uxCity" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ControlToValidate="uxCity" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align:center">
                    <asp:Button ID="uxAddCustomer" runat="server" Text="Submit" OnClick="uxAuthenticate_Click" CssClass="btn btn-primary"/>
                </td>
            </tr>
        </table>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    </div>
        </div>
</asp:Content>
