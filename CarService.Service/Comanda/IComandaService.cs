using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Service
{
    public interface IComandaService 
    {
        void CreateNew(ComandaDto autoDto);
        ComandaDto FindById(int autoId);
        void Update(ComandaDto autoDto);
        void Delete(ComandaDto autoDto);
    }
}
