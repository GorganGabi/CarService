using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Service
{
    public interface IImagineService
    {
        void CreateNew(ImagineDto imagineDto);
        ImagineDto FindById(int imagineId);
        void Update(ImagineDto imagineDto);
        void Delete(ImagineDto imagineDto);
    }
}
