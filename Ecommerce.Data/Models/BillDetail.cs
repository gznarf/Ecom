using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Data.Models
{
    public class BillDetail
    {
        [Key]
        public int ID_BillDetail { get; set; }
        public int ID_Bill { get; set; }
        public int ID_Client { get; set; }
        public DateTime dateTime { get; set; }
        [Required]
        [Column(TypeName="varchar(100)")]
        public int quantity { get; set; }
        [Required]
        [Column(TypeName ="Decimal(5,2)")]
        public decimal price { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
    }
}
