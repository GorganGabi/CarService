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
            //var sasiuRepository = new Repository<Sasiu>(unitOfWork);
            //var sasiuService = new SasiuService(sasiuRepository, unitOfWork);
            //var sasiuDto = new SasiuDto
            //{
            //    Id = 2,
            //    Denumire = "Fara Denumire"
            //};

            //sasiuService.Update(sasiuDto);

            var clientRepository = new Repository<Client>(unitOfWork);
            var clientService = new ClientService(clientRepository, unitOfWork);
            var client = new ClientDto
            {
                Nume = "Nume",
                Prenume = "Prenume",
                Email = "email@gmail.com",
                Adresa = "Adresa",
                Judet = "Judet",
                Localitate = "Localitate",
              
            };

            clientService.CreateNew(client);
        }
    }
}
