using CPRG214_Assignment1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPRG214.Assignment1.App
{
	public partial class Register : System.Web.UI.Page
	{
		int x = 2;
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void uxAuthenticate_Click(object sender, EventArgs e)
        {
			if (uxFName.Text == null || uxFName.Text == "" || uxLName.Text == null || uxLName.Text == "")
            {
				
            }
			else
            {
				var custID = MarinaManager.Authenticate(uxFName.Text, uxLName.Text);

				if (custID != null)
				{
					Session.Add("CustomerID", custID);

					FormsAuthentication.RedirectFromLoginPage(custID.ToString(), false);
				}
				else
                {
					uxRedirectAlert.Text = "Your name is not in our records; please check your spelling. ";
					Session.Add("CustomerFName", uxFName.Text);
					Session.Add("CustomerLName", uxLName.Text);
				}
			}
			
			
        }
    }
}