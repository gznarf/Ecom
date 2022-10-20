using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Data.Models
{
    public class Categorie
    {
        [Key]
        public int ID_Categorie { get; set; }
        [Required]
        [Column(TypeName = "Varchar(60)")]
        public string Name { get; set; }
        public int State { get; set; }

    }
}
