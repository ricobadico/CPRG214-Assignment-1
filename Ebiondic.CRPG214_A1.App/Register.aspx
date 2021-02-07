<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CPRG214.Assignment1.App.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
      <h3>Login</h3>
    <div class="col-md-4">
        <table class="table">
            <tr>
                <td style="width:150px">Username:</td>
                <td>
                    <asp:TextBox ID="uxUsername" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Password:</td>
                <td>
                    <asp:TextBox ID="uxPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="uxAuthenticate" runat="server" Text="Authenticate" OnClick="uxAuthenticate_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="uxMessage" ForeColor="Red" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
