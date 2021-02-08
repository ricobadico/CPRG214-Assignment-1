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

        public void fillSlipData(Slip slip)
        {
            lblID.Text = $"Slip #{slip.ID}";
            lblSize.Text = $"{slip.Width}W x {slip.Length}L";
            lblWater.Text = $"{(slip.Dock.WaterService ? "yes" : "no")}";
            lblElectric.Text = $"{(slip.Dock.ElectricalService ? "yes" : "no")}";
        }
    }
}