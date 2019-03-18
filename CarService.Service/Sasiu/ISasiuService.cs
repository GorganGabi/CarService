using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Service
{
    public interface ISasiuService
    {
        void CreateNew(SasiuDto sasiuDto);
        SasiuDto FindById(int sasiuId);
        void Update(SasiuDto sasiuDto);
        void Delete(SasiuDto sasiuDto);
    }
}
