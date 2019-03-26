using CarService.Infrastructure;
using ModelDesignFirst_L1;
using System;
using System.Linq;

namespace CarService.Service
{
    public class ComandaService : IComandaService
    {
        private readonly IRepository<Comanda> comandaRepository;
        private readonly IUnitOfWork unitOfWork;
        private enum StareComanda { InAsteptare, Executata, RefuzataLaExecutie };

        public ComandaService(IRepository<Comanda> comandaRepository, IUnitOfWork unitOfWork)
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
                DataFinalizare = comandaDto.DataFinalizare,
                DataProgramare = comandaDto.DataProgramare,
                DataSystem = comandaDto.DataSystem,
                Descriere = comandaDto.Descriere,
                DetaliuComanda = comandaDto.DetaliuComanda,
                KmBord = comandaDto.KmBord,
                StareComanda = (int)StareComanda.InAsteptare,
                ValoarePise = comandaDto.ValoarePise
            };

            comandaRepository.Add(comanda);
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

            var comanda = comandaRepository.Get(c => c.Id == comandaDto.Id).FirstOrDefault();

            comanda.Auto = comandaDto.Auto ?? comanda.Auto;
            comanda.DataFinalizare = comandaDto.DataFinalizare == default(DateTime) ? comanda.DataFinalizare : comandaDto.DataFinalizare;
            comanda.DataProgramare = comandaDto.DataProgramare == default(DateTime) ? comanda.DataProgramare : comandaDto.DataProgramare;
            comanda.DataSystem = comandaDto.DataSystem ?? comanda.DataSystem;
            comanda.Descriere = comandaDto.Descriere ?? comanda.Descriere;
            comanda.DetaliuComanda = comandaDto.DetaliuComanda ?? comanda.DetaliuComanda;
            comanda.KmBord = comandaDto.KmBord == default(int) ? comanda.KmBord : comandaDto.KmBord;
            comanda.StareComanda = comandaDto.StareComanda == default(int) ? comanda.StareComanda : comanda.StareComanda;
            comanda.ValoarePise = comandaDto.ValoarePise == default(int) ? comanda.ValoarePise : comanda.ValoarePise;

            unitOfWork.Commit();
        }

        public void Delete(int comandaId)
        {
            var comanda = comandaRepository.Get(s => s.Id == comandaId).FirstOrDefault();

            comandaRepository.Delete(comanda);
            unitOfWork.Commit();
        }
    }
}
