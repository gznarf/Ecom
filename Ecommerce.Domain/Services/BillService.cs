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
    public class BillService : IBillService
    {
        private readonly IBillRepository _billRepository;
        private readonly IMapper _mapper;

        public BillService(IBillRepository billRepository, IMapper mapper)
        {
            _billRepository = billRepository;
            _mapper = mapper;
        }

        public IEnumerable<BillDTO> GetAllBills()
        {
            var bill = _billRepository.GetAllBills();
            var billToReturn = _mapper.Map<IEnumerable<BillDTO>>(bill);
            return billToReturn;
        }

        public BillDTO GetById(int Id)
        {
            var bill = _billRepository.GetById(Id);
            var billToReturn = _mapper.Map<BillDTO>(bill);
            return billToReturn;
        }

        public void AddBill(BillDTO billDTO)
        {
            try
            {
                Bill bill = new Bill()
                {
                   
                }
            }

        }
    }
}
