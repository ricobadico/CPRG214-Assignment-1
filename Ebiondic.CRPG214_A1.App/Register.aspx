<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CPRG214.Assignment1.App.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
      <h3>Login</h3>
    <div class="col-md-4">
        <table class="table">
            <tr>
                <td style="width:150px">First Name:</td>
                <td>
                    <asp:TextBox ID="uxFName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Last Name:</td>
                <td>
                    <asp:TextBox ID="uxLName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="uxAuthenticate" runat="server" Text="Register" OnClick="uxAuthenticate_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:ValidationSummary ID="uxValidationSummary1" runat="server" />
            </tr>
        </table>
        <asp:Label ID="uxErrorMessage" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <asp:Label ID="uxRedirectAlert" runat="server" Text=""></asp:Label><asp:Label ID="uxRedirectLabelNatural" runat="server" Text="If you are a new customer, please click "></asp:Label><asp:LinkButton ID="uxRedirectLink" runat="server" PostBackUrl="~/NewCustomer">here</asp:LinkButton>
    </div>
</asp:Content>
