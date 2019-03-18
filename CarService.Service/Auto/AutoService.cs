using CarService.Infrastructure;
using CarService.Service;
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

            var auto = new Auto
            {
                Client = updateAuto.Client,
                Comanda = updateAuto.Comanda,
                NumarAuto = updateAuto.NumarAuto,
                Sasiu = updateAuto.Sasiu,
                SerieSasiu = updateAuto.SerieSasiu
            };

            autoRepository.Update(auto);
            unitOfWork.Commit();
        }

        public void Delete(AutoDto autoDto)
        {
            if (autoDto == null)
            {
                throw new ArgumentNullException(nameof(autoDto));
            }

            var auto = new Auto
            {
                Client = autoDto.Client,
                Comanda = autoDto.Comanda,
                NumarAuto = autoDto.NumarAuto,
                Sasiu = autoDto.Sasiu,
                SerieSasiu = autoDto.SerieSasiu
            };

            autoRepository.Delete(auto);
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

            var autoDto = new Auto
            {
                Client = auto.Client,
                Comanda = auto.Comanda,
                NumarAuto = auto.NumarAuto,
                Sasiu = auto.Sasiu,
                SerieSasiu = auto.SerieSasiu
            };

            return new AutoDto();
        }
    }
}
