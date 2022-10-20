using AutoMapper;
using Ecommerce.Data.Models;
using Ecommerce.Data.Repositories;
using Ecommerce.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Services
{
    public class CategorieService : ICategorieService
    {
        private readonly ICategorieRespository _catRepository;
        private readonly IMapper _mapper;

        public CategorieService(ICategorieRespository catRepository, IMapper mapper)
        {
            _catRepository = catRepository;
            _mapper = mapper;
        }

        public IEnumerable<CategorieDTO> GetAllCategories()
        {
            var categories = _catRepository.GetAllCategories();
            var categoriesToReturn = _mapper.Map<IEnumerable<CategorieDTO>>(categories);
            return categoriesToReturn;
        }

        public CategorieDTO GetById(int Id)
        {
            var category = _catRepository.GetById(Id);
            var categorieToReturn = _mapper.Map<CategorieDTO>(category);
            return categorieToReturn;
        }

        public void AddCategorie(CategorieDTO catDTO)
        {
            try
            {
                Categorie cat = new Categorie()
                {
                    Name = catDTO.Name,
                    State = catDTO.State
                };
                _catRepository.AddCategorie(cat);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public Categorie EditCategorie(int Id, CategorieDTO UpdateCategorie)
        {
            var oldCategorie = _catRepository.GetById(Id);
            if(oldCategorie != null)
            {
                oldCategorie.State = UpdateCategorie.State;
                oldCategorie.Name = UpdateCategorie.Name;
                try
                {
                    return _catRepository.EditCategorie(oldCategorie);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return null;
        }

        public bool DeleteCategorie(int Id)
        {
            if(Id <= 0)
            {
                return false;
            }
            
            var cat = _catRepository.GetById(Id);

            if(cat == null)
            {
                throw new ApplicationException("Categorie Not Found");
            }
            try
            {
                return _catRepository.DeleteCategorie(Id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
