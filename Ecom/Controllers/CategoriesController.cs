using Ecommerce.Data.Models;
using Ecommerce.Domain.DTO;
using Ecommerce.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategorieService _categoriesService;

        public CategoriesController(ICategorieService categoriesService)
        {
            _categoriesService = categoriesService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategorieDTO>>> GetCategories()
        {
            var categories = _categoriesService.GetAllCategories();
            if (categories == null)
            {
                return NotFound();
            }
            return Ok(categories);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<CategorieDTO>> GetCategorie(int id)
        {
            var categories = _categoriesService.GetAllCategories();
            if (categories == null)
            {
                return NotFound();
            }
            var cat = _categoriesService.GetById(id);

            if (cat == null)
            {
                return NotFound();
            }
            return Ok(cat);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategorie(int id, CategorieDTO categorie)
        {
            try
            {
                _categoriesService.EditCategorie(id, categorie);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Categorie>>PostCategorie(CategorieDTO categorie)
        {
            var categories = _categoriesService.GetAllCategories();
            if(categories == null)
            {
                return Problem("Entity set 'EcomDbContext.Categories' is null");
            }
            try
            {
                _categoriesService.AddCategorie(categorie);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Ok(categorie);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult>Delete(int id)
        {
            var categories = _categoriesService.GetAllCategories();
            if(categories == null)
            {
                return NotFound();
            }

            try
            {
                var deleteFlag = _categoriesService.DeleteCategorie(id);
                if (!deleteFlag)
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return NoContent();
        }
    }
}
