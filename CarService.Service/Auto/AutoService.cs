using CarService.Infrastructure;
using ModelDesignFirst_L1;
using System;
using System.Linq;

namespace CarService.Service
{
    public class AutoService : IAutoService
    {
        private readonly IRepository<Auto> autoRepository;
        private readonly IUnitOfWork unitOfWork;

        public AutoService(IRepository<Auto> autoRepository, IUnitOfWork unitOfWork)
        {
            this.autoRepository = autoRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateNew(AutoDto newAuto)
        {
            if (newAuto == null)
            {
                throw new ArgumentNullException(nameof(newAuto));
            }

            var auto = new Auto
            {
                Client = newAuto.Client,
                Comanda = newAuto.Comanda,
                NumarAuto = newAuto.NumarAuto,
                Sasiu = newAuto.Sasiu,
                SerieSasiu = newAuto.SerieSasiu             
            };

            autoRepository.Add(auto);
            unitOfWork.Commit();
        }

        public void Update(AutoDto updateAuto)
        {
            if (updateAuto == null)
            {
                throw new ArgumentNullException(nameof(updateAuto));
            }

            var auto = autoRepository.Get(a => a.Id == updateAuto.Id).FirstOrDefault();

            auto.Client = updateAuto.Client ?? auto.Client;
            auto.Comanda = updateAuto.Comanda ?? auto.Comanda;
            auto.NumarAuto = updateAuto.NumarAuto ?? auto.NumarAuto;
            auto.Sasiu = updateAuto.Sasiu ?? auto.Sasiu;
            auto.SerieSasiu = updateAuto.SerieSasiu ?? auto.SerieSasiu;

            unitOfWork.Commit();
        }

        public AutoDto FindById(int autoId)
        {
            if (autoId < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(autoId));
            }

            var auto = autoRepository.Query(a => a.Id == autoId)
                                     .FirstOrDefault();

            if (auto == null)
            {
                return null;
            }

            var autoDto = new AutoDto
            {
                Client = auto.Client,
                Comanda = auto.Comanda,
                NumarAuto = auto.NumarAuto,
                Sasiu = auto.Sasiu,
                SerieSasiu = auto.SerieSasiu
            };

            return autoDto;
        }

        public void Delete(int autoId)
        {
            var comanda = autoRepository.Get(s => s.Id == autoId).FirstOrDefault();

            autoRepository.Delete(comanda);
            unitOfWork.Commit();
        }
    }
}
