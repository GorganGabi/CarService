using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Service
{
    public interface IClientService
    {
        void CreateNew(ClientDto clientDto);
        ClientDto FindById(int clientId);
        void Update(ClientDto clientDto);
        void Delete(ClientDto clientDto);
    }
}
