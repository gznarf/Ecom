using Ecommerce.Data.Models;
using Ecommerce.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Services
{
    public interface ICategorieService
    {
        public IEnumerable<CategorieDTO> GetAllCategories();

        public CategorieDTO GetById(int Id);

        public void AddCategorie(CategorieDTO Categorie);

        public Categorie EditCategorie(int Id, CategorieDTO UpdateCategorie);

        public bool DeleteCategorie(int Id);
    }
}
