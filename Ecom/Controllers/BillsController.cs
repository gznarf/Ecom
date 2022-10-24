using Ecommerce.Data.Models;
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

        [HttpPost]
        public async Task<ActionResult<Bill>>PostBill(BillDTO bill)
        {
            var bills = _billService.GetAllBills();
            if(bills == null)
            {
                return Problem("Entity set 'EcomDbContext.Bill' is null");
            }
            try
            {
                _billService.AddBill(bill);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return Ok(bill);
        }
    }
}
