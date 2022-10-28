using Ecommerce.Data.Models;
using Ecommerce.Domain.DTO;
using Ecommerce.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace Ecom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clienteService;

        public ClientController(IClientService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientDTO>>> GetClients()
        {
            var client = _clienteService.GetAllClients();
            if(client == null)
            {
                return NotFound();
            }
            return Ok(client);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ClientDTO>>GetClient(int id)
        {
            var clients = _clienteService.GetAllClients();
            if(clients == null)
            {
                return NotFound();
            }
            var client = _clienteService.GetById(id);
            if(client == null)
            {
                return NotFound();
            }
            return Ok(client);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult>PutClient(int id, ClientDTO client)
        {
            try
            {
            _clienteService.EditClient(id, client);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Client>>PostClient(ClientDTO client)
        {
            var clients = _clienteService.GetAllClients();
            if(client == null)
            {
                return Problem("Entity set 'EcomDbContext.Clients' is null");
            }
            try
            {
                _clienteService.AddClient(client);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return Ok(client);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult>Delete(int id)
        {
            var client = _clienteService.GetAllClients();
            if(client == null)
            {
                return NotFound();
            }

            try
            {
                var deleteFlag = _clienteService.DeleteClient(id);
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
