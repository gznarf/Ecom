using Ecommerce.Data.Models;
using Ecommerce.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Services
{
    public interface IBillService
    {
        public IEnumerable<BillDTO> GetAllBills();
        public BillDTO GetById(int id);
        public void AddBill(BillDTO bill);

    }
}
