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
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;

        public ClientService(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        public IEnumerable<ClientDTO> GetAllClients()
        {
            var clients = _clientRepository.GetAllClients();
            var clientToReturn = _mapper.Map<IEnumerable<ClientDTO>>(clients);
            return clientToReturn; ;
        }

        public ClientDTO GetById(int Id)
        {
            var client = _clientRepository.GetById(Id);
            var clientToReturn = _mapper.Map<ClientDTO>(client);
            return clientToReturn;
        }

        public void AddClient(ClientDTO clientDTO)
        {
            try
            {
                Client client = new Client()
                {
                    Name = clientDTO.Name,
                    LastName = clientDTO.LastName,
                    phone = clientDTO.Phone,
                    Address = clientDTO.Address,
                    City = clientDTO.City,
                    PostalCode = clientDTO.PostalCode,
                    Email = clientDTO.Email,
                };
                _clientRepository.AddClient(client);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Client EditClient(int Id, ClientDTO updateClient)
        {
            var oldClient = _clientRepository.GetById(Id);
            if(oldClient != null)
            {
                oldClient.Name = updateClient.Name;
                oldClient.LastName = updateClient.LastName;
                oldClient.phone = updateClient.Phone;
                oldClient.Address = updateClient.Address;
                oldClient.City = updateClient.City;
                oldClient.PostalCode = updateClient.PostalCode;
                oldClient.Email = updateClient.Email;
                try
                {
                    return _clientRepository.EditClient(oldClient);
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
            return null;
        }

        public bool DeleteClient(int Id)
        {
            if(Id <= 0) return false;

            var client = _clientRepository.GetById(Id);
            if(client == null)
            {
                throw new ApplicationException("Client Not Found");
            }
            try
            {
                return _clientRepository.DeleteClient(Id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
