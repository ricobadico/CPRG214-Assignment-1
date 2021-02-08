using CPRG214.Assignment1.Data;
using CPRG214_Assignment1.App.Controls;
using CPRG214_Assignment1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPRG214.Assignment1.App.Secure
{
    public partial class Lease : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlDock.DataSource = DockManager.GetDocks();
                ddlDock.DataTextField = "Name";
                ddlDock.DataValueField = "ID";
                ddlDock.DataBind();
                ddlDock.SelectedIndex = 0;
                pnlStep2.Visible = false;
            }
        }

        protected void ddlDock_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dockID = Convert.ToInt32(ddlDock.SelectedValue);
            grdSlipsDock.DataSource = SlipManager.getFreeSlipDataForViewing(dockID);
            pnlStep2.Visible = true;
            DataBind();
        }

        protected void grdSlipsDock1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                FormattingHelper.gridHeaderFormat(e);
            }
        }

        protected void grdSlipsDock_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument);
            GridViewRow currentRow = grdSlipsDock.Rows[rowIndex];

            string slipID = ((Label)grdSlipsDock.Rows[currentRow.RowIndex].FindControl("SlipID")).Text;

            System.Diagnostics.Debug.WriteLine(slipID);
        }
    }
}