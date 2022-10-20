using Ecommerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Data.Repositories
{
    public interface ICategorieRespository
    {
        public IEnumerable<Categorie> GetAllCategories();
        public Categorie GetById(int id);
        public void AddCategorie(Categorie categorie);
        public Categorie EditCategorie(Categorie updateCategorie);
        public bool DeleteCategorie(int id);    
    }
}
