using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Data.Models
{
    public class Product
    {
        [Key]
        public int ID_Product { get; set; }
        [Required]
        public int Cod_Product { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "varchar(500)")]
        public string Description { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Mark { get; set; }
        [Required]
        [Column(TypeName ="Decimal(5,2)")]
        public decimal Price { get; set; }
        public DateTime Created { get; set; }
        [Required]
        public int Stock { get; set; }
        public int ID_Categorie { get; set; }
        public List<Categorie> Categories { get; set; } = new List<Categorie>();
    }
}
