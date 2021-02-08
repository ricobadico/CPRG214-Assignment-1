using CPRG214_Assignment1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPRG214.Assignment1.App.Controls
{
    public partial class SlipData : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // When created on the Slips page, this method is called with the given slip. 
        // This renders the slip data in visual form according to this control
        public void fillSlipData(Slip slip)
        {
            // Fill text boxes with data
            lblID.Text = $"Slip #{slip.ID}";
            lblSize.Text = $"{slip.Width}W x {slip.Length}L";
            lblWater.Text = $"{(slip.Dock.WaterService ? "Water" : "-")}";
            lblElectric.Text = $"{(slip.Dock.ElectricalService ? "Electrical" : "-")}";

         
        }
    }
}