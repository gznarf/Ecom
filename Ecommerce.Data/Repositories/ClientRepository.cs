using Ecommerce.Data.Data;
using Ecommerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly EcomDbContext _context;

        public ClientRepository(EcomDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Client> GetAllClients()
        {
            return _context.Clients;
        }

        public Client GetById(int Id)
        {
            return _context.Clients.Find(Id);
        }

        public void AddClient(Client client)
        {
            if(client != null)
            {
                try
                {
                    _context.Clients.Add(client);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public Client EditClient(Client updateClient)
        {
            try
            {
                _context.Update(updateClient);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return updateClient;
        }

        public bool DeleteClient(int id)
        {
            var client = _context.Clients.Find(id);
            if(client != null)
            {
                try
                {
                    _context.Clients.Remove(client);
                    _context.SaveChanges();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
                return true;
            }
            return false;
        }
    }
}
