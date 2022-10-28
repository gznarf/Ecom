using AutoMapper;
using Ecommerce.Data.Models;
using Ecommerce.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Extensions
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Categorie, CategorieDTO>();
            CreateMap<Product, ProductDTO>();
            CreateMap<Bill, BillDTO>();
            CreateMap<BillDetail, BillDetailDTO>();
            CreateMap<Client, ClientDTO>();
            
        }
    }
}
