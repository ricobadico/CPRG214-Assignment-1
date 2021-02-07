using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG214.Assignment1.Data
{
    public class SlipManager
    {
        public static List<Slip> GetAllSlips()
        {
            MarinaEntities db = new MarinaEntities();
            var slips = db.Slips.ToList();
            return slips;
        }

        public static List<Slip> GetFreeSlips()
        {
            // Go to the database and get lease and slip data
            MarinaEntities db = new MarinaEntities();
            List<Lease> leases = db.Leases.ToList();
            List<Slip> slips = db.Slips.ToList();

            // Use lease list to grab leased Slip IDs
            List<int> leasedSlipIDs = leases.Select(lease => lease.SlipID).ToList();

            // Grab all slips where the slip id is not among the list of leased slip ids 
            List<Slip> freeSlips = slips.Where(slip => !leasedSlipIDs.Contains(slip.ID)).ToList();

            return freeSlips;
        }
    }
}
