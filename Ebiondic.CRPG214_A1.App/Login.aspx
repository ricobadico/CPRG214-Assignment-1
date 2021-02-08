<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CPRG214.Assignment1.App.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
      <h3>Login</h3>
    <div class="col-md-4">
        <table class="table">
            <tr>
                <td style="width:150px">Username:</td>
                <td>
                    <asp:TextBox ID="uxUsername" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="uxUsernameVali" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="uxUsername" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Password:</td>
                <td>
                    <asp:TextBox ID="uxPassword" runat="server" TextMode="Password"></asp:TextBox><asp:RequiredFieldValidator ID="uxPasswordVali" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="uxPassword" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="uxAuthenticate" runat="server" Text="Authenticate" OnClick="uxAuthenticate_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:ValidationSummary ID="uxValidationSummary1" runat="server" />
            </tr>
        </table>
    </div>
</asp:Content>
