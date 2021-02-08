using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CPRG214.Assignment1.Data;

namespace CPRG214.Assignment1.App
{
    public partial class Slips : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Get data from database
                grdSlipsDock1.DataSource = SlipManager.GetFreeSlipsByDock(1);
                grdSlipsDock2.DataSource = SlipManager.GetFreeSlipsByDock(2);
                grdSlipsDock3.DataSource = SlipManager.GetFreeSlipsByDock(3);
                DataBind();

            }
        }

        // Below is some code formatting headers in the tables; 
        // without a pre-set DataSource, couldn't figure out how to do this in designer.
        protected void grdSlipsDock1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                gridHeaderFormat(e);
            }
        }

        protected void grdSlipsDock2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            gridHeaderFormat(e);

        }

        protected void grdSlipsDock3_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            gridHeaderFormat(e);

        }

        /// <summary>
        /// Formats the datagrid that just auto populated to have formatted header names
        /// </summary>
        /// <param name="e">Data from the event that triggered it</param>
        public void gridHeaderFormat(GridViewRowEventArgs e)
        {
            e.Row.Cells[0].Text = "ID #";
            e.Row.Cells[1].Text = "Width (m)";
            e.Row.Cells[2].Text = "Length (m)";
        }
    }
}