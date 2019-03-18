using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Service
{
    public interface IService<T> where T: IDto
    {
        void CreateNew(T auto);
        T FindById(int autoId);
        void Update(T autoDto);
        void Delete(T autoDto);
    }
}
