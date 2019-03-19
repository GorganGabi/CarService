using CarService.Infrastructure;
using ModelDesignFirst_L1;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CarService.Service
{
    public class ClientService : IClientService
    {
        private readonly IRepository<Client> clientRepository;
        private readonly UnitOfWork unitOfWork;

        public ClientService(IRepository<Client> clientRepository, UnitOfWork unitOfWork)
        {
            this.clientRepository = clientRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateNew(ClientDto clientDto)
        {
            if (clientDto == null)
            {
                throw new ArgumentNullException(nameof(clientDto));
            }

            var client = new Client
            {
                Adresa = clientDto.Adresa,
                Auto = clientDto.Auto,
                Comanda = clientDto.Comanda,
                Email = clientDto.Email,
                Judet = clientDto.Judet,
                Localitate = clientDto.Localitate,
                Nume = clientDto.Nume,
                Prenume = clientDto.Prenume,
                Telefon = clientDto.Telefon

            };

            clientRepository.Add(client);
            unitOfWork.Commit();
        }

        public void Delete(ClientDto clientDto)
        {
            if (clientDto == null)
            {
                throw new ArgumentNullException(nameof(clientDto));
            }

            var client = new Client
            {
                Adresa = clientDto.Adresa,
                Auto = clientDto.Auto,
                Comanda = clientDto.Comanda,
                Email = clientDto.Email,
                Judet = clientDto.Judet,
                Localitate = clientDto.Localitate,
                Nume = clientDto.Nume,
                Prenume = clientDto.Prenume,
                Telefon = clientDto.Telefon

            };

            clientRepository.Delete(client);
            unitOfWork.Commit();

        }

        public ClientDto FindById(int clientId)
        {

            if (clientId < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(clientId));
            }

            var client = clientRepository.Query(a => a.Id == clientId)
                                         .FirstOrDefault();

            if (client == null)
            {
                return null;
            }

            var clientDto = new ClientDto
            {
                Adresa = client.Adresa,
                Auto = client.Auto,
                Comanda = client.Comanda,
                Email = client.Email,
                Judet = client.Judet,
                Localitate = client.Localitate,
                Nume = client.Nume,
                Prenume = client.Prenume,
                Telefon = client.Telefon
            };

            return clientDto;
        }

        public void Update(ClientDto clientDto)
        {
            if (clientDto == null)
            {
                throw new ArgumentNullException(nameof(clientDto));
            }

            var client = new Client
            {
                Adresa = clientDto.Adresa,
                Auto = clientDto.Auto,
                Comanda = clientDto.Comanda,
                Email = clientDto.Email,
                Judet = clientDto.Judet,
                Localitate = clientDto.Localitate,
                Nume = clientDto.Nume,
                Prenume = clientDto.Prenume,
                Telefon = clientDto.Telefon

            };

            clientRepository.Update(client);
            unitOfWork.Commit();
        }
    }
}
