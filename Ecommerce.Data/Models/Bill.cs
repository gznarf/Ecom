using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Data.Models
{
    public class Bill
    {
        [Key]
        public int ID_Bill { get; set; }
        public int ID_BillDetail { get; set; }
        public int ID_Client { get; set; }
        public string date { get; set; }
        public double total { get; set; }
        public int BillNumber { get; set; }

        public List<Bill> BillList { get; set; } = new List<Bill>();
    }
}
