using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.DTO
{
    public class BillDetailDTO
    {
        public int ID_BillDetail { get; set; }
        public int ID_Bill { get; set; }
        public int Id_Client { get; set; }
        public DateTime dateTime { get; set; }
        public int quantiity { get; set; }
        public decimal price { get; set; }
        public List<ProductDTO> products { get; set; }
    }
}
