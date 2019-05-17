using CarService.Infrastructure.EF;
using ModelDesignFirst_L1;
using System;
using System.Linq;

namespace CarService.Service.EF
{
    public class ImagineService : IImagineService
    {
        private readonly IRepository<Imagine> imagineRepository;
        private readonly IUnitOfWork unitOfWork;

        public ImagineService(IRepository<Imagine> imagineRepository, IUnitOfWork unitOfWork)
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
                //DetaliuComanda = imagineDto.DetaliuComanda,
                Foto = imagineDto.Foto,
                Titlu = imagineDto.Titlu
            };

            imagineRepository.Add(imagine);
            unitOfWork.Commit();
        }

        public void Delete(int imagineId)
        {
            var imagine = imagineRepository.Get(s => s.Id == imagineId).FirstOrDefault();

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
                //DetaliuComanda = imagine.DetaliuComanda,
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

            var imagine = imagineRepository.Get(i => i.Id == imagineDto.Id).FirstOrDefault();

            imagine.Data = imagineDto.Data == default(DateTime) ? imagine.Data : imagineDto.Data;
            imagine.Descriere = imagineDto.Descriere ?? imagine.Descriere;
            //imagine.DetaliuComanda = imagineDto.DetaliuComanda ?? imagine.DetaliuComanda;
            imagine.Foto = imagineDto.Foto ?? imagine.Foto;
            imagine.Titlu = imagineDto.Titlu ?? imagine.Titlu;

            unitOfWork.Commit();
        }
    }
}
