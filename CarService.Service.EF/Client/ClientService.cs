﻿using CarService.Infrastructure.EF;
using ModelDesignFirst_L1;
using System;
using System.Linq;

namespace CarService.Service.EF
{
    public class ClientService : IClientService
    {
        private readonly IRepository<Client> clientRepository;
        private readonly IUnitOfWork unitOfWork;

        public ClientService(IRepository<Client> clientRepository, IUnitOfWork unitOfWork)
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
                //Auto = clientDto.Auto,
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

        public void Delete(int clientId)
        {
            var client = clientRepository.Get(s => s.Id == clientId).FirstOrDefault();

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
                //Auto = client.Auto,
                Email = client.Email,
                Judet = client.Judet,
                Localitate = client.Localitate,
                Nume = client.Nume,
                Prenume = client.Prenume,
                Telefon = client.Telefon
            };

            return clientDto;
        }

        public ClientDto GetCars(int clientId)
        {
            if (clientId < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(clientId));
            }

            var clientCars = clientRepository.Query(c => c.Id == clientId)
                                             .SelectMany(c => c.Auto)
                                             .ToList();

            var clientDto = new ClientDto
            {
                //Auto = clientCars
            };

            return clientDto; 
        }

        public void Update(ClientDto clientDto)
        {
            if (clientDto == null)
            {
                throw new ArgumentNullException(nameof(clientDto));
            }

            var client = clientRepository.Get(c => c.Id == clientDto.Id).FirstOrDefault();

            client.Judet = clientDto.Judet ?? client.Judet;
            client.Localitate = clientDto.Localitate ?? client.Localitate;
            client.Nume = clientDto.Nume ?? client.Nume;
            client.Telefon = clientDto.Telefon == default(decimal) ? client.Telefon : clientDto.Telefon;
            client.Adresa = clientDto.Adresa ?? client.Adresa;
            //client.Auto = clientDto.Auto ?? client.Auto;
            client.Email = clientDto.Email ?? client.Email;

            unitOfWork.Commit();
        }
    }
}
