using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Service
{
    public interface IOperatieService
    {
        void CreateNew(OperatieDto operatieDto);
        OperatieDto FindById(int operatieId);
        void Update(OperatieDto operatieDto);
        void Delete(OperatieDto operatieDto);
    }
}
