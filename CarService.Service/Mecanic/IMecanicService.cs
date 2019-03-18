using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Service
{
    public interface IMecanicService
    {
        void CreateNew(MecanicDto mecanicDto);
        MecanicDto FindById(int mecanicId);
        void Update(MecanicDto mecanicDto);
        void Delete(MecanicDto mecanicDto);
    }
}
