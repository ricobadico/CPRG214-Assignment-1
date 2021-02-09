<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CPRG214.Assignment1.App.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="d-flex flex-column justify-content-center align-items-center">
      <h2 class="m-4 text-center">Login</h2>
    <div class="col-md-6">
        <table class="table">
            <tr>
                <td class="text-primary">First Name:</td>
                <td>
                    <asp:TextBox ID="uxFName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="uxFName" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="text-primary">Last Name:</td>
                <td>
                    <asp:TextBox ID="uxLName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="uxLName" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align:center">
                    <asp:Button ID="uxAuthenticate" runat="server" Text="Log In" OnClick="uxAuthenticate_Click" CssClass="btn btn-primary mt-2"/>
                </td>
            </tr>
        </table>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
       
        <asp:Label ID="uxRedirectAlert" runat="server" Text=""></asp:Label>
        <div style="text-align:center">
            <asp:Label ID="uxRedirectLabelNatural" runat="server" Text="If you are a new customer, please " Font-Size="X-Large"></asp:Label>
            <br />
            <asp:LinkButton ID="uxRedirectLink" runat="server" PostBackUrl="~/NewCustomer" CausesValidation="False" CssClass="btn btn-primary mt-3">Register</asp:LinkButton>
        </div>
        
    </div>
    </div>
</asp:Content>
