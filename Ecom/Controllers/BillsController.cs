using Ecommerce.Domain.DTO;
using Ecommerce.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillsController : ControllerBase
    {
        private readonly IBillService _billService;

        public BillsController(IBillService billService)
        {
            _billService = billService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BillDTO>>> GetBills()
        {
            var bill = _billService.GetAllBills();
            if (bill == null)
            {
                return NotFound();
            }
            return Ok(bill);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<BillDTO>>GetBill(int id)
        {
            var bill = _billService.GetAllBills();
            if(bill == null)
            {
                return NotFound();
            }
            var BillOK = _billService.GetById(id);
            if(BillOK == null)
            {
                return NotFound();
            }
            return Ok(BillOK);
        }
    }
}
