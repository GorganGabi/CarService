using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Service
{
    public interface IMaterialService
    {
        void CreateNew(IMaterialService materialDto);
        IMaterialService FindById(int materialId);
        void Update(IMaterialService materialDto);
        void Delete(IMaterialService materialDto);
    }
}
