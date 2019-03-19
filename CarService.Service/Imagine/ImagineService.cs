using CarService.Infrastructure;
using ModelDesignFirst_L1;
using System;
using System.Linq;

namespace CarService.Service
{
    public class ImagineService : IImagineService
    {
        private readonly IRepository<Imagine> imagineRepository;
        private readonly UnitOfWork unitOfWork;

        public ImagineService(IRepository<Imagine> imagineRepository, UnitOfWork unitOfWork)
        {
            this.imagineRepository = imagineRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateNew(ImagineDto imagineDto)
        {
            if (imagineDto == null)
            {
                throw new ArgumentNullException(nameof(imagineDto));
            }

            var imagine = new Imagine
            {
                Data = imagineDto.Data,
                Descriere = imagineDto.Descriere,
                DetaliuComanda = imagineDto.DetaliuComanda,
                Foto = imagineDto.Foto,
                Titlu = imagineDto.Titlu
            };

            imagineRepository.Add(imagine);
            unitOfWork.Commit();
        }

        public void Delete(ImagineDto imagineDto)
        {
            if (imagineDto == null)
            {
                throw new ArgumentNullException(nameof(imagineDto));
            }

            var imagine = new Imagine
            {
                Data = imagineDto.Data,
                Descriere = imagineDto.Descriere,
                DetaliuComanda = imagineDto.DetaliuComanda,
                Foto = imagineDto.Foto,
                Titlu = imagineDto.Titlu
            };

            imagineRepository.Delete(imagine);
            unitOfWork.Commit();
        }

        public ImagineDto FindById(int imagineId)
        {
            if (imagineId < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(imagineId));
            }

            var imagine = imagineRepository.Query(a => a.Id == imagineId)
                                         .FirstOrDefault();

            if (imagine == null)
            {
                return null;
            }

            var imagineDto = new ImagineDto
            {
                Data = imagine.Data,
                Descriere = imagine.Descriere,
                DetaliuComanda = imagine.DetaliuComanda,
                Foto = imagine.Foto,
                Titlu = imagine.Titlu
            };

            return imagineDto;
        }

        public void Update(ImagineDto imagineDto)
        {
            if (imagineDto == null)
            {
                throw new ArgumentNullException(nameof(imagineDto));
            }

            var imagine = new Imagine
            {
                Data = imagineDto.Data,
                Descriere = imagineDto.Descriere,
                DetaliuComanda = imagineDto.DetaliuComanda,
                Foto = imagineDto.Foto,
                Titlu = imagineDto.Titlu
            };

            imagineRepository.Update(imagine);
            unitOfWork.Commit();
        }
    }
}
