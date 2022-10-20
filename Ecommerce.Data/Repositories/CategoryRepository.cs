using Ecommerce.Data.Data;
using Ecommerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Data.Repositories
{
    public class CategoryRepository : ICategorieRespository
    {
        private readonly EcomDbContext _context;

        public CategoryRepository(EcomDbContext context)
        {
            _context = context;
        }   

        public IEnumerable<Categorie> GetAllCategories()
        {
            return _context.Categories;
        }

        public Categorie GetById(int Id)
        {
            return _context.Categories.Find(Id);
        }

        public void AddCategorie(Categorie Categorie)
        {
            if(Categorie != null)
            {
                try
                {
                    _context.Categories.Add(Categorie);
                    _context.SaveChanges();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }

        public Categorie EditCategorie(Categorie UpdateCategorie)
        {
            try
            {
                _context.Update(UpdateCategorie);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return UpdateCategorie;
        }

        public bool DeleteCategorie(int Id)
        {
            var categorie = _context.Categories.Find(Id);
            if(categorie != null)
            {
                try
                {
                    _context.Categories.Remove(categorie);
                    _context.SaveChanges();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
                return true;
            }
            return false;
        }
    }
}
