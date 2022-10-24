using Ecommerce.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Services
{
    public interface IBillDetailService
    {
        public IEnumerable<BillDetailDTO> GetBillDetails();
        public BillDetailDTO GetById(int id);
        public void AddBillDetail(BillDetailDTO billDetail);
    }
}
