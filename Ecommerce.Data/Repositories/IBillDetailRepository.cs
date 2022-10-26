using Ecommerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Data.Repositories
{
    public interface IBillDetailRepository
    {
        public IEnumerable<BillDetail> GetAllBillDetails();
        public BillDetail GetById(int id);
        public void AddBillDetail(BillDetail billDetail);
    }
}
