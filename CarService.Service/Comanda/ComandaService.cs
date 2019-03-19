using CarService.Infrastructure;
using ModelDesignFirst_L1;
using System;
using System.Linq;

namespace CarService.Service
{
    public class ComandaService : IComandaService
    {
        private readonly IRepository<Comanda> comandaRepository;
        private readonly UnitOfWork unitOfWork;

        public ComandaService(IRepository<Comanda> comandaRepository, UnitOfWork unitOfWork)
        {
            this.comandaRepository = comandaRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateNew(ComandaDto comandaDto)
        {
            if (comandaDto == null)
            {
                throw new ArgumentNullException(nameof(comandaDto));
            }

            var comanda = new Comanda
            {
                Auto = comandaDto.Auto,
                Client = comandaDto.Client,
                DataFinalizare  = comandaDto.DataFinalizare, 
                DataProgramare = comandaDto.DataProgramare,
                DataSystem = comandaDto.DataSystem,
                Descriere = comandaDto.Descriere,
                DetaliuComanda = comandaDto.DetaliuComanda,
                KmBord = comandaDto.KmBord,
                StareComanda = comandaDto.StareComanda,
                ValoarePise = comandaDto.ValoarePise
            };

            comandaRepository.Add(comanda);
            unitOfWork.Commit();
        }

        public void Delete(ComandaDto comandaDto)
        {
            if (comandaDto == null)
            {
                throw new ArgumentOutOfRangeException(nameof(comandaDto));
            }

            var comanda = new Comanda
            {
                Auto = comandaDto.Auto,
                Client = comandaDto.Client,
                DataFinalizare = comandaDto.DataFinalizare,
                DataProgramare = comandaDto.DataProgramare,
                DataSystem = comandaDto.DataSystem,
                Descriere = comandaDto.Descriere,
                DetaliuComanda = comandaDto.DetaliuComanda,
                KmBord = comandaDto.KmBord,
                StareComanda = comandaDto.StareComanda,
                ValoarePise = comandaDto.ValoarePise
            };

            comandaRepository.Delete(comanda);
            unitOfWork.Commit();
        }

        public ComandaDto FindById(int comandaId)
        {
            if (comandaId < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(comandaId));
            }

            var comanda = comandaRepository.Query(a => a.Id == comandaId)
                                         .FirstOrDefault();

            if (comanda == null)
            {
                return null;
            }

            var comandaDto = new ComandaDto
            {
                Auto = comanda.Auto,
                Client = comanda.Client,
                DataFinalizare = comanda.DataFinalizare,
                DataProgramare = comanda.DataProgramare,
                DataSystem = comanda.DataSystem,
                Descriere = comanda.Descriere,
                DetaliuComanda = comanda.DetaliuComanda,
                KmBord = comanda.KmBord,
                StareComanda = comanda.StareComanda,
                ValoarePise = comanda.ValoarePise
            };

            return comandaDto;
        }

        public void Update(ComandaDto comandaDto)
        {
            if (comandaDto == null)
            {
                throw new ArgumentOutOfRangeException(nameof(comandaDto));
            }

            var comanda = new Comanda
            {
                Auto = comandaDto.Auto,
                Client = comandaDto.Client,
                DataFinalizare = comandaDto.DataFinalizare,
                DataProgramare = comandaDto.DataProgramare,
                DataSystem = comandaDto.DataSystem,
                Descriere = comandaDto.Descriere,
                DetaliuComanda = comandaDto.DetaliuComanda,
                KmBord = comandaDto.KmBord,
                StareComanda = comandaDto.StareComanda,
                ValoarePise = comandaDto.ValoarePise
            };

            comandaRepository.Update(comanda);
            unitOfWork.Commit();
        }
    }
}
