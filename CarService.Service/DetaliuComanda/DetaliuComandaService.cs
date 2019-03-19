using CarService.Infrastructure;
using ModelDesignFirst_L1;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CarService.Service
{
    public class DetaliuComandaService : IDetaliuComandaService
    {
        private readonly IRepository<DetaliuComanda> detaliuComandaRepository;
        private readonly UnitOfWork unitOfWork;

        public DetaliuComandaService(IRepository<DetaliuComanda> detaliuComandaRepository, UnitOfWork unitOfWork)
        {
            this.detaliuComandaRepository = detaliuComandaRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateNew(DetaliuComandaDto detaliuComandaDto)
        {
            if (detaliuComandaDto == null)
            {
                throw new ArgumentNullException(nameof(detaliuComandaDto));
            }

            var detaliuComanda = new DetaliuComanda
            {
                Comanda = detaliuComandaDto.Comanda,
                Imagines = detaliuComandaDto.Imagines,
                Materials = detaliuComandaDto.Materials,
                Mecanici = detaliuComandaDto.Mecanici,
                Operaties = detaliuComandaDto.Operaties
            };

            detaliuComandaRepository.Add(detaliuComanda);
            unitOfWork.Commit();
        }

        public void Delete(DetaliuComandaDto detaliuComandaDto)
        {
            if (detaliuComandaDto == null)
            {
                throw new ArgumentNullException(nameof(detaliuComandaDto));
            }

            var detaliuComanda = new DetaliuComanda
            {
                Comanda = detaliuComandaDto.Comanda,
                Imagines = detaliuComandaDto.Imagines,
                Materials = detaliuComandaDto.Materials,
                Mecanici = detaliuComandaDto.Mecanici,
                Operaties = detaliuComandaDto.Operaties
            };

            detaliuComandaRepository.Delete(detaliuComanda);
            unitOfWork.Commit();

        }

        public DetaliuComandaDto FindById(int detaliuComandaId)
        {
            if (detaliuComandaId < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(detaliuComandaId));
            }

            var detaliuComanda = detaliuComandaRepository.Query(a => a.Id == detaliuComandaId)
                                         .FirstOrDefault();

            if (detaliuComanda == null)
            {
                return null;
            }

            var detaliuComandaDto = new DetaliuComandaDto
            {
                Comanda = detaliuComanda.Comanda,
                Imagines = detaliuComanda.Imagines,
                Materials = detaliuComanda.Materials,
                Mecanici = detaliuComanda.Mecanici,
                Operaties = detaliuComanda.Operaties
            };

            return detaliuComandaDto;
        }

        public void Update(DetaliuComandaDto detaliuComandaDto)
        {
            if (detaliuComandaDto == null)
            {
                throw new ArgumentNullException(nameof(detaliuComandaDto));
            }

            var detaliuComanda = new DetaliuComanda
            {
                Comanda = detaliuComandaDto.Comanda,
                Imagines = detaliuComandaDto.Imagines,
                Materials = detaliuComandaDto.Materials,
                Mecanici = detaliuComandaDto.Mecanici,
                Operaties = detaliuComandaDto.Operaties
            };

            detaliuComandaRepository.Update(detaliuComanda);
            unitOfWork.Commit();
        }
    }
}
