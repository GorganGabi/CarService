using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Service
{
    public interface IDetaliuComandaService
    {
        void CreateNew(DetaliuComandaDto detaliuComandaDto);
        DetaliuComandaDto FindById(int detaliuComandaId);
        void Update(DetaliuComandaDto detaliuComandaDto);
        void Delete(DetaliuComandaDto detaliuComandaDto);
    }
}
