using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Service
{
    public interface IClientService
    {
        void CreateNew(ClientDto autoDto);
        ClientDto FindById(int autoId);
        void Update(ClientDto autoDto);
        void Delete(ClientDto autoDto);
    }
}
