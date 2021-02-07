<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="CPRG214.Assignment1.App.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="text-center p-3">Contact Us</h2>
    
    <div class="container">

        <div class="row">
            <div class="col-sm">
                <h4>Address</h4>
                <address>
                    Inland Lake Marina <br /> 
                    Box 123<br />
                    Inland Lake, Arizona 86038<br />
                </address>
            </div>
      
            <div class="col-sm">
                <h4>Phone</h4>
                <address>
                   Office: 928-555-2234 <br />
                    Leasing: 928-555-2235 <br />
                    Fax: 928-555-2236 <br />
                </address>
            </div>
   
            <div class="col-sm">
                <h4>Contacts</h4>
                <address>
                    <strong>Manager</strong>   Glenn Cooke<br />
                    <strong>Slip Manager:</strong> Kimberly Carlson <br />
                    <strong>Contact email:</strong> <a href="mailto:info@inlandmarina.com">info@inlandmarina.com</a>
                </address>
            </div>
        </div>

    </div>
    
</asp:Content>
