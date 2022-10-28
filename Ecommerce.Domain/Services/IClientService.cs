using Ecommerce.Data.Models;
using Ecommerce.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Services
{
    public interface IClientService
    {
        public IEnumerable<ClientDTO> GetAllClients();
        public ClientDTO GetById(int Id);
        public void AddClient(ClientDTO client);
        public Client EditClient(int Id, ClientDTO updateClient);
        public bool DeleteClient(int Id);   
    }
}
