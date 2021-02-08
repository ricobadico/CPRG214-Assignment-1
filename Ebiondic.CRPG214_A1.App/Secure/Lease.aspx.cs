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
            if (Session["CustomerID"] == null)
            {
                Response.Redirect("~/Register");
            }

            if (!IsPostBack)
            {
<<<<<<< HEAD
                // Bind Dock Data to dropdown
                ddlDock.DataSource = DockManager.GetDocks();
=======
                ddlDock.DataSource = MarinaManager.GetDocks();
>>>>>>> 7d8d9b8f80bdbedfed997759b7859f5059c6e89d
                ddlDock.DataTextField = "Name";
                ddlDock.DataValueField = "ID";
                ddlDock.DataBind();

                // Set up default dropdown/page view
                ddlDock.SelectedIndex = 0;
<<<<<<< HEAD
                //pnlStep2.Visible = false;
            }
=======
                pnlStep2.Visible = false;            }
>>>>>>> 7d8d9b8f80bdbedfed997759b7859f5059c6e89d
        }

        // Fires whenever the dropdown changes to update the data grid
        protected void ddlDock_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get dock id from withing dropdown selection
            int dockID = Convert.ToInt32(ddlDock.SelectedValue);
<<<<<<< HEAD

            // Use dock id to get a list of all free slips at that dock, use it as gridview datasource
            grdSlipsDock.DataSource = SlipManager.getFreeSlipDataForViewing(dockID);
=======
            grdSlipsDock.DataSource = MarinaManager.getFreeSlipDataForViewing(dockID);
            pnlStep2.Visible = true;
>>>>>>> 7d8d9b8f80bdbedfed997759b7859f5059c6e89d
            DataBind();

            // Show grid if currently hidden
            //pnlStep2.Visible = true;
            
        }

        // Fires when the data grid's data source changes (after dropdown change)
        protected void grdSlipsDock1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            // Applies formatting to the headers of datagrid
            if (e.Row.RowType == DataControlRowType.Header)
            {
                FormattingHelper.gridHeaderFormat(e);
            }
        }

        // Fires whenever a command is fired from a row (using the button column)
        protected void grdSlipsDock_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // Get index of datagrid from event
            int rowIndex = Convert.ToInt32(e.CommandArgument);
            
            // Get row object corresponding to that index 
            GridViewRow currentRow = grdSlipsDock.Rows[rowIndex];

            // Pull the Slip ID out of the current row (it sits at column index 1)
            int slipID = Convert.ToInt32(grdSlipsDock.Rows[currentRow.RowIndex].Cells[1].Text);

            // Insert the new lease info to the database
            SlipManager.InsertNewLease(slipID);

            // Alert the user
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('[Purchasing happens here] Congrats! The slip has been successfully leased.')", true);
            
            // Refresh the datagrid display to remove the leased slip
            ddlDock_SelectedIndexChanged(this, e);
        }
    }
}