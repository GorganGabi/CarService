using CarService.Infrastructure;
using CarService.Service;
using ModelDesignFirst_L1;
using System;

namespace CarService.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var autoContext = new CarServiceContext();

            var unitOfWork = new UnitOfWork(autoContext);

            var autoRepository = new Repository<Auto>(unitOfWork);

            var autoService = new AutoService(autoRepository, unitOfWork);

            var auto = new AutoDto
            {
                NumarAuto = "",
                //Sasiu = new Sasiu
                //{
                //    CodSasiu = "CodSasiu",
                //    Denumire= "Denumire",                   
                //},
                SerieSasiu = ""
            };
            
            autoService.CreateNew(auto);
            unitOfWork.Commit();

        }
    }
}
