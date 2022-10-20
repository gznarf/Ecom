using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.DTO
{
    public class CategorieDTO
    {
      
        public int ID_Categorie { get; set; }
        [Required]
        [Column(TypeName = "Varchar(60)")]
        public string Name { get; set; }
        public int State { get; set; }
    }
}
