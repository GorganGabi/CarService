using CarService.Infrastructure.EF;
using CarService.Service.EF;
using ModelDesignFirst_L1;

namespace CarService.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var autoContext = new CarServiceContext();
            var unitOfWork = new UnitOfWork(autoContext);

            var autoRepository = new Repository<Auto>(unitOfWork);
            var clientRepository = new Repository<Client>(unitOfWork);
            var sasiuRepository = new Repository<Sasiu>(unitOfWork);


            var clientService = new ClientService(clientRepository, unitOfWork);
            var autoService = new AutoService(autoRepository, unitOfWork);
            var sasiuService = new SasiuService(sasiuRepository, unitOfWork);

            var sasiuDto = new SasiuDto
            {
                Denumire = "Fara Denumire",
                CodSasiu = "8D"
            };

            var updateSasiu = sasiuService.FindById(3);
            updateSasiu.CodSasiu = "8D";
            
            //sasiuService.CreateNew(sasiuDto);
            sasiuService.Update(updateSasiu);

            /*var client = new ClientDto
            {
                Nume = "Nume1",
                Prenume = "Prenume1",
                Email = "email1@gmail.com",
                Adresa = "Adresa1",
                Judet = "Judet1",
                Localitate = "Localitate1"
            };*/

            //clientService.CreateNew(client);
            //clientService.Delete(5);
        }
    }
}
