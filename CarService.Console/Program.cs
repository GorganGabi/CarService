using CarService.Infrastructure;
using CarService.Service;
using ModelDesignFirst_L1;

namespace CarService.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var autoContext = new CarServiceContext();

            var unitOfWork = new UnitOfWork(autoContext);

            var sasiuRepository = new Repository<Sasiu>(unitOfWork);

            var sasiuService = new SasiuService(sasiuRepository, unitOfWork);

            var sasiu = new SasiuDto
            {
                Denumire = "DenumireSasiu",
                CodSasiu = "4F"
            };

            sasiuService.CreateNew(sasiu);

        }
    }
}
