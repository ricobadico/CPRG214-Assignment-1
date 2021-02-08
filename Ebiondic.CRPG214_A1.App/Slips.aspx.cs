using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CPRG214_Assignment1.App.Controls;
using CPRG214_Assignment1.Data;

namespace CPRG214.Assignment1.App
{
    public partial class Slips : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Get data from database
                grdSlipsDock1.DataSource = MarinaManager.getFreeSlipDataForViewing(1);
                grdSlipsDock2.DataSource = MarinaManager.getFreeSlipDataForViewing(2);
                grdSlipsDock3.DataSource = MarinaManager.getFreeSlipDataForViewing(3);
                DataBind();

            }
        }

        // Below is some code formatting headers in the tables; 
        // without a pre-set DataSource, couldn't figure out how to do this in designer.
        protected void grdSlipsDock1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                FormattingHelper.gridHeaderFormat(e);
            }
        }

        protected void grdSlipsDock2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                FormattingHelper.gridHeaderFormat(e);
            }
        }

        protected void grdSlipsDock3_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                FormattingHelper.gridHeaderFormat(e);
            }
        }

    }
}