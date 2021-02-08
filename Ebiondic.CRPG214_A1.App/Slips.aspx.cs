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
<<<<<<< HEAD
=======
                // Get data from database
                grdSlipsDock1.DataSource = MarinaManager.getFreeSlipDataForViewing(1);
                grdSlipsDock2.DataSource = MarinaManager.getFreeSlipDataForViewing(2);
                grdSlipsDock3.DataSource = MarinaManager.getFreeSlipDataForViewing(3);
                DataBind();
>>>>>>> 7d8d9b8f80bdbedfed997759b7859f5059c6e89d

                ddlDock.DataSource = DockManager.GetDocks();
                ddlDock.DataTextField = "Name";
                ddlDock.DataValueField = "ID";
                ddlDock.DataBind();
                ddlDock.SelectedIndex = 0;

                FillSlipDisplay(1, slipContainer1);


            }
        }

        private void FillSlipDisplay(int dockID, Panel container)
        {
            // get the list of free slips of the given dock
            var freeSlips = SlipManager.GetFreeSlipsByDock(dockID);

            for (int i = 0; i< freeSlips.Count; i++)
            {
                App.Controls.SlipData slipDisplay = (App.Controls.SlipData)Page.LoadControl("~/Controls/SlipData.ascx");
                container.Controls.Add(slipDisplay);
                slipDisplay.fillSlipData(freeSlips[i]);
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

        protected void ddlDock_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dockID = Convert.ToInt32(ddlDock.SelectedValue);
            FillSlipDisplay(dockID, slipContainer1);

        }
    }
}