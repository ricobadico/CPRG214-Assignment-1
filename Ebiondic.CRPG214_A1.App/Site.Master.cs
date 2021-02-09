using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPRG214.Assignment1.App
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // depending on the state of authentcation
            if (Context.User.Identity.IsAuthenticated)
            {
                // alter the innerHtml of the element ID
                // the ID needs to have the runatserver
                // the full name was set by the Authentication manager code on login
               
                uxWelcome.InnerHtml = $"Welcome {Session["CustomerFName"].ToString()}";
               

                // if the user is logged in you want the icon to indicate click to logout
                uxLogin.InnerHtml = "Log Out";

                uxRegister.Visible = false;
            }
            else
            {
                // if the user is logged out you want the icon to indicate click to login
                uxLogin.InnerHtml = "Log In";

                // empty string for the uxWelcome element
                uxWelcome.InnerHtml = string.Empty;

                uxRegister.Visible = true;
            }
        }

        protected void HandleLoginClick(object sender, EventArgs e)
        {
            // check if Context.User.Identity.IsAuthenticated
            // Signout aut ticket, clear session, redirect

            // This code is used to swicth the state of elements on the main layout 
            // depending on the state of authentcation
            if (Context.User.Identity.IsAuthenticated)
            {
                // from system.web.security
                // remove the auth ticket from the browser
                FormsAuthentication.SignOut();
                // Clear the session
                Session.Clear();
                // Redirect to home page
                Response.Redirect("~/");

            }
            else
            {
                // redirect to login page
                Response.Redirect("~/Register");
            }


            // example of alert from a response
            //Response.Write("<script>alert('Login Clicked');</script>");
        }
    }
}