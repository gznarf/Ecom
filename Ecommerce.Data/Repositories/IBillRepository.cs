using Ecommerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Data.Repositories
{
    public interface IBillRepository
    {
        public IEnumerable<Bill> GetAllBills();
        public Bill GetById(int id);
        public void AddBill(Bill bill);


    }
}
