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
    public class BillDetailService : IBillDetailService
    {
        private readonly IBillDetailRepository _billDetailRepository;
        private readonly IMapper _mapper;

        public BillDetailService(IBillDetailRepository billDetailRepository, IMapper mapper)
        {
            _billDetailRepository = billDetailRepository;
            _mapper = mapper;
        }

        public IEnumerable<BillDetailDTO> GetBillDetails()
        {
            var billDetail = _billDetailRepository.GetBillDetails();
            var billDetailToReturn = _mapper.Map<IEnumerable<BillDetailDTO>>(billDetail);
            return billDetailToReturn;
        }

        public BillDetailDTO GetById(int Id)
        {
            var billDetail = _billDetailRepository.GetById(Id);
            var billDetailToReturn = _mapper.Map<BillDetailDTO>(billDetail);
            return billDetailToReturn;
        }

        public void AddBillDetail(BillDetailDTO billDetailDTO)
        {
            try
            {
                BillDetail billDetail = new BillDetail()
                {
                    ID_Bill = billDetailDTO.ID_Bill,
                    ID_Client = billDetailDTO.Id_Client,
                    dateTime = billDetailDTO.dateTime,
                    price = billDetailDTO.price,
                    quantity = billDetailDTO.quantiity,
                    
                };
                _billDetailRepository.AddBillDatail(billDetail);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
