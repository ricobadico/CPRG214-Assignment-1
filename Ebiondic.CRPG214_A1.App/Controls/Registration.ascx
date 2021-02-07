<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Registration.ascx.cs" Inherits="CPRG214.Assignment1.App.Controls.Registration" %>

<br />
<h3>Registration Add/Update</h3>
<br />
<asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="0" OnFinishButtonClick="Wizard1_FinishButtonClick">
    <WizardSteps>
        <asp:WizardStep ID="WizardStep1" runat="server" Title="Student Profile">
            <table class="table">
                <tr>
                    <td style="width:150px">First Name</td>
                    <td>
                        <asp:TextBox ID="uxFirstName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Last Name:</td>
                    <td>
                        <asp:TextBox ID="uxLastName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>City:</td>
                    <td>
                        <asp:TextBox ID="uxCity" runat="server"></asp:TextBox></td>
                </tr>
            </table>
        </asp:WizardStep>
        <asp:WizardStep ID="WizardStep2" runat="server" Title="Security Credentials">
            <table>
                <tr>
                    <td style="width:150px">Username:</td>
                    <td>
                        <asp:TextBox ID="uxUsername" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Password:</td>
                    <td>
                        <asp:TextBox ID="uxPassword" runat="server"></asp:TextBox></td>
                </tr>
            </table>
        </asp:WizardStep>
    </WizardSteps>
</asp:Wizard>