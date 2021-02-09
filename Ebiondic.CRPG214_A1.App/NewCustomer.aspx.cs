using CPRG214_Assignment1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPRG214_Assignment1.App
{
    public partial class NewCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CustomerFname"] != null) 
                uxFName.Text = Session["CustomerFname"].ToString();
            if (Session["CustomerLname"] != null) 
                uxLName.Text = Session["CustomerLname"].ToString();
        }

        protected void uxAuthenticate_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                FirstName = uxFName.Text,
                LastName = uxLName.Text,
                Phone = uxPhone.Text,
                City = uxCity.Text
            };

            MarinaManager.AddCustomer(customer);

            var custID = MarinaManager.Authenticate(uxFName.Text, uxLName.Text);

            Session.Add("CustomerID", custID);

            Response.Redirect("~/Secure/Lease");
        }
    }
}