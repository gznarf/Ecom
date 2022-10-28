using Ecommerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Data.Repositories
{
    public  interface IClientRepository
    {
        public IEnumerable<Client> GetAllClients();
        public Client GetById(int id);
        public void AddClient(Client client);
        public Client EditClient(Client updateClient);
        public bool DeleteClient(int id);
    }
}
