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
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="uxFName" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Last Name:</td>
                <td>
                    <asp:TextBox ID="uxLName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="uxLName" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="uxAuthenticate" runat="server" Text="Register" OnClick="uxAuthenticate_Click" />
                </td>
            </tr>
        </table>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
        <br />
        <asp:Label ID="uxRedirectAlert" runat="server" Text=""></asp:Label><asp:Label ID="uxRedirectLabelNatural" runat="server" Text="If you are a new customer, please click "></asp:Label><asp:LinkButton ID="uxRedirectLink" runat="server" PostBackUrl="~/NewCustomer" CausesValidation="False">here</asp:LinkButton>
    </div>
</asp:Content>
