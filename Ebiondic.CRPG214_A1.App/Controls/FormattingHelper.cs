using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace CPRG214_Assignment1.App.Controls
{
    public class FormattingHelper
    {
        /// <summary>
        /// Formats the datagrid that just auto populated to have formatted header names
        /// </summary>
        /// <param name="e">Data from the event that triggered it</param>
        public static void gridHeaderFormat(GridViewRowEventArgs e)
        {
            e.Row.Cells[1].Text = "ID #";
            e.Row.Cells[2].Text = "Width (m)";
            e.Row.Cells[3].Text = "Length (m)";
        }
    }
}