using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
			x = 4;
        }
    }
}