using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.DTO
{
    public class BillDTO
    {
        public int ID_Bill { get; set; }
        public int ID_BillDetail { get; set; }
        public int ID_Client { get; set; }
         public string date { get; set; }
        public double total { get; set; }
        public int BillNumber { get; set; }

    }
}
