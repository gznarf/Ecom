using Ecommerce.Data.Data;
using Ecommerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Data.Repositories
{
    public class BillDetailRepository : IBillDetailRepository
    {
        private readonly EcomDbContext _context;

        public BillDetailRepository(EcomDbContext context)
        {
            _context = context;
        }

        public IEnumerable<BillDetail> GetAllBills()
        {
            return _context.BillDetails;
        }

        public BillDetail GetById(int Id)
        {
            return _context.BillDetails.Find(Id);
        }

        public void AddBillDetail(BillDetail billDetail)
        {
            if(billDetail != null)
            {
                try
                {
                    _context.BillDetails.Add(billDetail);
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
