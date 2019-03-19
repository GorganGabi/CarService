using CarService.Infrastructure;
using ModelDesignFirst_L1;
using System;
using System.Linq;

namespace CarService.Service
{
    public class SasiuService : ISasiuService
    {
        private readonly IRepository<Sasiu> sasiuRepository;
        private readonly UnitOfWork unitOfWork;

        public SasiuService(IRepository<Sasiu> sasiuRepository, UnitOfWork unitOfWork)
        {
            this.sasiuRepository = sasiuRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateNew(SasiuDto sasiuDto)
        {
            if (sasiuDto == null)
            {
                throw new ArgumentNullException(nameof(sasiuDto));
            }

            var sasiu = new Sasiu
            {
                Auto = sasiuDto.Auto,
                CodSasiu = sasiuDto.CodSasiu,
                Denumire = sasiuDto.Denumire,

            };

            sasiuRepository.Add(sasiu);
            unitOfWork.Commit();
        }

        public void Delete(SasiuDto sasiuDto)
        {
            if (sasiuDto == null)
            {
                throw new ArgumentNullException(nameof(sasiuDto));
            }

            var sasiu = new Sasiu
            {
                Auto = sasiuDto.Auto,
                CodSasiu = sasiuDto.CodSasiu,
                Denumire = sasiuDto.Denumire,

            };

            sasiuRepository.Delete(sasiu);
            unitOfWork.Commit();
        }

        public SasiuDto FindById(int sasiuId)
        {
            if (sasiuId < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(sasiuId));
            }

            var sasiu = sasiuRepository.Query(s => s.Id == sasiuId)
                                       .FirstOrDefault();


            if (sasiu == null)
            {
                return null;
            }

            var sasiuDto = new SasiuDto
            {
                Auto = sasiu.Auto,
                CodSasiu = sasiu.CodSasiu,
                Denumire = sasiu.Denumire,

            };

            return sasiuDto;
        }

        public void Update(SasiuDto sasiuDto)
        {
            if (sasiuDto == null)
            {
                throw new ArgumentNullException(nameof(sasiuDto));
            }

            var sasiu = sasiuRepository.Get(s => s.Id == sasiuDto.Id).FirstOrDefault();

            sasiu.Auto = sasiuDto.Auto ?? sasiu.Auto;
            sasiu.CodSasiu = sasiuDto.CodSasiu ?? sasiu.CodSasiu;
            sasiu.Denumire = sasiuDto.Denumire ?? sasiu.Denumire;

            unitOfWork.Commit();
        }
    }
}
