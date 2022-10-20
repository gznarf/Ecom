using Ecommerce.Data.Data;
using Ecommerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Data.Repositories
{
    public class BillRepository : IBillRepository
    {
        private readonly EcomDbContext _context;

        public BillRepository(EcomDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Bill> GetAllBills()
        {
            return _context.Bills;
        }

        public Bill GetById(int Id)
        {
            return _context.Bills.Find(Id);
        }

        public void AddBill(Bill bill)
        {
            if(bill != null)
            {
                try
                {
                    _context.Bills.Add(bill);
                    _context.SaveChanges();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }

    }
}
