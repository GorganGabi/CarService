using CarService.Infrastructure.EF;
using ModelDesignFirst_L1;
using System;
using System.Linq;

namespace CarService.Service.EF
{
    public class MaterialService : IMaterialService
    {
        private readonly IRepository<Material> materialRepository;
        private readonly IUnitOfWork unitOfWork;

        public MaterialService(IRepository<Material> materialRepository, IUnitOfWork unitOfWork)
        {
            this.materialRepository = materialRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateNew(MaterialDto materialDto)
        {
            if (materialDto == null)
            {
                throw new ArgumentNullException(nameof(materialDto));
            }

            var material = new Material
            {
                Cantitate = materialDto.Cantitate,
                DataAprovizionare = materialDto.DataAprovizionare,
                Denumire = materialDto.Denumire,
                //DetaliuComanda = materialDto.DetaliuComanda,
                Pret = materialDto.Pret
            };

            materialRepository.Add(material);
            unitOfWork.Commit();
        }

        public void Delete(int materialId)
        {
            var material = materialRepository.Get(s => s.Id == materialId).FirstOrDefault();

            materialRepository.Delete(material);
            unitOfWork.Commit();
        }

        public MaterialDto FindById(int materialId)
        {
            if (materialId < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(materialId));
            }

            var material = materialRepository.Query(m => m.Id == materialId)
                                            .FirstOrDefault();

            if (material == null)
            {
                return null;
            }

            var materialDto = new MaterialDto
            {
                Cantitate = material.Cantitate,
                DataAprovizionare = material.DataAprovizionare,
                Denumire = material.Denumire,
                //DetaliuComanda = material.DetaliuComanda,
                Pret = material.Pret
            };

            return materialDto;
        }

        public void Update(MaterialDto materialDto)
        {
            if (materialDto == null)
            {
                throw new ArgumentNullException(nameof(materialDto));
            }

            var material = materialRepository.Get(m => m.Id == materialDto.Id).FirstOrDefault();

            material.Cantitate = materialDto.Cantitate == default(decimal) ? material.Cantitate : materialDto.Cantitate;
            material.DataAprovizionare = materialDto.DataAprovizionare == default(DateTime) ? material.DataAprovizionare : materialDto.DataAprovizionare;
            material.Denumire = materialDto.Denumire ?? material.Denumire;
            //material.DetaliuComanda = materialDto.DetaliuComanda ?? material.DetaliuComanda;
            material.Pret = materialDto.Pret == default(int) ? material.Pret : materialDto.Pret;

            unitOfWork.Commit();
        }
    }
}
