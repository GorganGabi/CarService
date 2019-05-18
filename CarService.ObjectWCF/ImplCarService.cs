using CarService.Infrastructure.EF;
using CarService.Service.EF;
using ModelDesignFirst_L1;

namespace CarService.ObjectWCF
{
    public class ImplCarService : InterfaceCarService
    {
        private readonly AutoService autoService;
        private readonly ClientService clientService;
        private readonly ComandaService comandaService;
        private readonly DetaliuComandaService detaliuComandaService;
        private readonly ImagineService imagineService;
        private readonly MaterialService materialService;
        private readonly MecanicService mecanicService;
        private readonly OperatieService operatieService;
        private readonly SasiuService sasiuService;


        public ImplCarService()
        {
            var autoContext = new CarServiceContext();
            var unitOfWork = new UnitOfWork(autoContext);

            var autoRepository = new Repository<Auto>(unitOfWork);
            var clientRepository = new Repository<Client>(unitOfWork);
            var comandaRepository = new Repository<Comanda>(unitOfWork);
            var detaliuComandaRepository = new Repository<DetaliuComanda>(unitOfWork);
            var imagineRepository = new Repository<Imagine>(unitOfWork);
            var materialRepository = new Repository<Material>(unitOfWork);
            var mecanicRepository = new Repository<Mecanic>(unitOfWork);
            var operatieRepository = new Repository<Operatie>(unitOfWork);
            var sasiuRepository = new Repository<Sasiu>(unitOfWork);

            clientService = new ClientService(clientRepository, unitOfWork);
            autoService = new AutoService(autoRepository, unitOfWork);
            comandaService = new ComandaService(comandaRepository, unitOfWork);
            detaliuComandaService = new DetaliuComandaService(detaliuComandaRepository, unitOfWork);
            imagineService = new ImagineService(imagineRepository, unitOfWork);
            materialService = new MaterialService(materialRepository, unitOfWork);
            mecanicService = new MecanicService(mecanicRepository, unitOfWork);
            operatieService = new OperatieService(operatieRepository, unitOfWork);
            sasiuService = new SasiuService(sasiuRepository, unitOfWork);
        }
        public void CreateNewAuto(AutoDto autoDto)
        {
            autoService.CreateNew(autoDto);
        }

        public void CreateNewClient(ClientDto clientDto)
        {
            clientService.CreateNew(clientDto);
        }

        public void CreateNewComanda(ComandaDto comandaDto)
        {
            comandaService.CreateNew(comandaDto);
        }

        public void CreateNewDetaliuComanda(DetaliuComandaDto detaliuComandaDto)
        {
            detaliuComandaService.CreateNew(detaliuComandaDto);
        }

        public void CreateNewImagine(ImagineDto imagineDto)
        {
            imagineService.CreateNew(imagineDto);
        }

        public void CreateNewMaterial(MaterialDto materialDto)
        {
            materialService.CreateNew(materialDto);
        }

        public void CreateNewMecanic(MecanicDto mecanicDto)
        {
            mecanicService.CreateNew(mecanicDto);
        }

        public void CreateNewOperatie(OperatieDto operatieDto)
        {
            operatieService.CreateNew(operatieDto);
        }

        public void CreateNewSasiu(SasiuDto sasiuDto)
        {
            sasiuService.CreateNew(sasiuDto);
        }

        public void DeleteAuto(int autoId)
        {
            autoService.Delete(autoId);
        }

        public void DeleteClient(int clientId)
        {
            clientService.Delete(clientId);
        }

        public void DeleteComanda(int comandaId)
        {
            comandaService.Delete(comandaId);
        }

        public void DeleteDetaliuComanda(int detaliuComandaId)
        {
            detaliuComandaService.Delete(detaliuComandaId);
        }

        public void DeleteImagine(int imagineId)
        {
            imagineService.Delete(imagineId);
        }

        public void DeleteMaterial(int materialId)
        {
            materialService.Delete(materialId);
        }

        public void DeleteMecanic(int mecanicId)
        {
            mecanicService.Delete(mecanicId);
        }

        public void DeleteOperatie(int operatieId)
        {
            operatieService.Delete(operatieId);
        }

        public void DeleteSasiu(int sasiuId)
        {
            sasiuService.Delete(sasiuId);
        }

        public AutoDto FindByIdAuto(int autoId)
        {
            return autoService.FindById(autoId);
        }

        public ClientDto FindByIdClient(int clientId)
        {
            return clientService.FindById(clientId);
        }

        public ComandaDto FindByIdComanda(int comandaId)
        {
            return comandaService.FindById(comandaId);
        }

        public DetaliuComandaDto FindByIdDetaliuComanda(int detaliuComandaId)
        {
            return detaliuComandaService.FindById(detaliuComandaId);
        }

        public ImagineDto FindByIdImagine(int imagineId)
        {
            return imagineService.FindById(imagineId);
        }

        public MaterialDto FindByIdMaterial(int materialId)
        {
            return materialService.FindById(materialId);
        }

        public MecanicDto FindByIdMecanic(int mecanicId)
        {
            return mecanicService.FindById(mecanicId);
        }

        public OperatieDto FindByIdOperatie(int operatieId)
        {
            return operatieService.FindById(operatieId);
        }

        public SasiuDto FindByIdSasiu(int sasiuId)
        {
            return sasiuService.FindById(sasiuId);
        }

        public ClientDto GetCarsClient(int clientId)
        {
            return clientService.GetCars(clientId);
        }

        public void UpdateAuto(AutoDto autoDto)
        {
            autoService.Update(autoDto);
        }

        public void UpdateClient(ClientDto clientDto)
        {
            clientService.Update(clientDto);
        }

        public void UpdateComanda(ComandaDto comandaDto)
        {
            comandaService.Update(comandaDto);
        }

        public void UpdateDetaliuComanda(DetaliuComandaDto detaliuComandaDto)
        {
            detaliuComandaService.Update(detaliuComandaDto);
        }

        public void UpdateImagine(ImagineDto imagineDto)
        {
            imagineService.Update(imagineDto);
        }

        public void UpdateMaterial(MaterialDto materialDto)
        {
            materialService.Update(materialDto);
        }

        public void UpdateMecanic(MecanicDto mecanicDto)
        {
            mecanicService.Update(mecanicDto);
        }

        public void UpdateOperatie(OperatieDto operatieDto)
        {
            operatieService.Update(operatieDto);
        }

        public void UpdateSasiu(SasiuDto sasiuDto)
        {
            sasiuService.Update(sasiuDto);
        }
    }
}
