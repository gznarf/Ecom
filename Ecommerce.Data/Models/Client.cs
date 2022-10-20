using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Data.Models
{
    public class Client
    {
        [Key]
        public int ID_Client { get; set; }
        [Required]
        [Column(TypeName="varchar(30)")]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string LastName { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string phone { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Address { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string City { get; set; }
        [Required]
        [Column(TypeName = "varchar(8)")]
        public string PostalCode { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }
        public DateTime Created { get; set; }

        public List<Bill> Bills { get; set; } = new List<Bill>();
    }
}
