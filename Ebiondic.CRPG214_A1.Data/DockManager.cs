using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG214_Assignment1.Data
{
    public class DockManager
    {
        public static List<Dock> GetDocks()
        {
            MarinaEntities db = new MarinaEntities();
            List<Dock> docks = db.Docks.ToList();

            return docks;
        }


    }
}
