using CarService.Infrastructure;
using ModelDesignFirst_L1;
using System;
using System.Linq;

namespace CarService.Service
{
    public class MecanicService : IMecanicService
    {
        private readonly IRepository<Mecanic> mecanicRepository;
        private readonly IUnitOfWork unitOfWork;

        public MecanicService(IRepository<Mecanic> mecanicRepository, IUnitOfWork unitOfWork)
        {
            this.mecanicRepository = mecanicRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateNew(MecanicDto mecanicDto)
        {
            if (mecanicDto == null)
            {
                throw new ArgumentOutOfRangeException(nameof(mecanicDto));
            }

            var mecanic = new Mecanic
            {
                DetaliuComanda = mecanicDto.DetaliuComanda,
                Nume = mecanicDto.Nume,
                Prenume = mecanicDto.Prenume
            };

            mecanicRepository.Add(mecanic);
            unitOfWork.Commit();
        }

        public void Delete(int mecanicId)
        {
            var mecanic = mecanicRepository.Get(s => s.Id == mecanicId).FirstOrDefault();

            mecanicRepository.Delete(mecanic);
            unitOfWork.Commit();
        }

        public MecanicDto FindById(int mecanicId)
        {
            if (mecanicId < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(mecanicId));
            }

            var mecanic = mecanicRepository.Query(m => m.Id == mecanicId)
                                            .FirstOrDefault();

            if (mecanic == null)
            {
                return null;
            }

            var mecanicDto = new MecanicDto
            {
                DetaliuComanda = mecanic.DetaliuComanda,
                Nume = mecanic.Nume,
                Prenume = mecanic.Prenume
            };

            return mecanicDto;
        }

        public void Update(MecanicDto mecanicDto)
        {
            if (mecanicDto == null)
            {
                throw new ArgumentOutOfRangeException(nameof(mecanicDto));
            }

            var mecanic = mecanicRepository.Get(m => m.Id == mecanicDto.Id).FirstOrDefault();

            mecanic.Nume = mecanicDto.Nume ?? mecanic.Nume;
            mecanic.Prenume = mecanicDto.Prenume ?? mecanic.Prenume;
            mecanic.DetaliuComanda = mecanicDto.DetaliuComanda ?? mecanic.DetaliuComanda;

            unitOfWork.Commit();
        }
    }
}
