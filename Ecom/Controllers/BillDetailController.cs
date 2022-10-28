using Ecommerce.Data.Models;
using Ecommerce.Domain.DTO;
using Ecommerce.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillDetailController : ControllerBase
    {
        private readonly IBillDetailService _billDetailService;

        public BillDetailController(IBillDetailService billDetailService)
        {
            _billDetailService = billDetailService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BillDetailDTO>>> GetBillDetails()
        {
            var billDetails = _billDetailService.GetBillDetails();
            if(billDetails == null)
            {
                return NotFound();
            }
            return Ok(billDetails);
        }

        [HttpGet("{id:int}")]
        public  async Task<ActionResult<BillDetailDTO>>GetBillDetail(int id)
        {
            var billDetails = _billDetailService.GetBillDetails();
            if(billDetails == null)
            {
                return NotFound();
            }

            var billDetail = _billDetailService.GetById(id);

            if(billDetail == null)
            {
                return NotFound();
            }
            return Ok(billDetail);
        }

        [HttpPost]
        public async Task<ActionResult<BillDetail>>PostBillDetail(BillDetailDTO billDetail)
        {
            var billDetails = _billDetailService.GetBillDetails();
            if(billDetails == null)
            {
                return Problem("Entity set 'EcomDbContext.Billdetail' is null");
            }
            try
            {
                _billDetailService.AddBillDetail(billDetail);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return Ok(billDetails);
        }
    }
}
