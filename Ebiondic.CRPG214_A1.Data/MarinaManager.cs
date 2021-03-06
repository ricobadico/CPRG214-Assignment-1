﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG214_Assignment1.Data
{
    public class MarinaManager
    {
        public static List<Dock> GetDocks()
        {
            MarinaEntities db = new MarinaEntities();
            List<Dock> docks = db.Docks.ToList();

            return docks;
        }

        public static List<Slip> GetAllSlips()
        {
            MarinaEntities db = new MarinaEntities();
            var slips = db.Slips.ToList();
            //return slips;
            return slips;
        }

        /// <summary>
        /// Get all unleased slips from a particular dock
        /// </summary>
        /// <param name="DockID">The ID of the chosen Dock</param>
        /// <returns></returns>
        public static List<Slip> GetFreeSlipsByDock(int DockID)
        {
            // Go to the database and get lease and slip data
            MarinaEntities db = new MarinaEntities();
            List<Lease> leases = db.Leases.ToList();
            List<Slip> slipsInDock = db.Slips.Where(slip => slip.DockID == DockID).ToList();

            // Use lease list to grab leased Slip IDs
            List<int> leasedSlipIDs = leases.Select(lease => lease.SlipID).ToList();

            // Grab all slips where the slip id is not among the list of leased slip ids 
            List<Slip> freeSlipsInDock = slipsInDock.Where(slip => !leasedSlipIDs.Contains(slip.ID)).ToList();

            return freeSlipsInDock;
        }

        /// <summary>
        /// Gets unleased slip data in a format needed for data grid presentation
        /// </summary>
        /// <param name="DockID">ID of the dock chosen</param>
        /// <returns></returns>
        public static IList getFreeSlipDataForViewing(int DockID)
        {

            List<Slip> freeSlipsInDock = GetFreeSlipsByDock(DockID);

            // Finally, get just the needed data for a more presentable finish
            var slipData = freeSlipsInDock.Select(slip => new
            {
                SlipID = slip.ID,
                Width = slip.Width,
                Length = slip.Length
            }
                ).ToList();

            return slipData;
        }

        /// <summary>
        /// Inserts a new entry into the Leases table,
        /// using the SlipID of an unleased slip.
        /// </summary>
        /// <param name="slipID"></param>
        public static void InsertNewLease(int slipID)
        {
            // Connect to db
            MarinaEntities db = new MarinaEntities();

            // grab slip object using the provided ID
            Slip slip = db.Slips.
                SingleOrDefault(s => s.ID == slipID);

            // grab customer object using session
            int custId = 1; //TODO get from session
            Customer cust = db.Customers.
                SingleOrDefault(c => c.ID == custId);

            Lease newLease = new Lease
            {
                SlipID = slipID,
                CustomerID = custId,
                Customer = cust,
                Slip = slip
            };

            db.Leases.Add(newLease);
        }

        public static int? Authenticate(string fname, string lname)
        {
            int? custID = null;
            var db = new MarinaEntities();
            var customer = db.Customers.
                SingleOrDefault(cust => cust.FirstName == fname && cust.LastName == lname);

            if (customer != null)
            {
                custID = customer.ID;
            }

            return custID;
        }

        public static void AddCustomer(Customer customer)
        {
            var db = new MarinaEntities();
            db.Customers.Add(customer);

            db.SaveChanges();
        }
    }
}
