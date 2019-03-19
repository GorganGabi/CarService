using CarService.Infrastructure;
using ModelDesignFirst_L1;
using System;
using System.Linq;

namespace CarService.Service
{
    public class OperatieService : IOperatieService
    {
        private readonly IRepository<Operatie> operatieRepository;
        private readonly UnitOfWork unitOfWork;

        public OperatieService(IRepository<Operatie> operatieRepository, UnitOfWork unitOfWork)
        {
            this.operatieRepository = operatieRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateNew(OperatieDto operatieDto)
        {
            if (operatieDto == null)
            {
                throw new ArgumentNullException(nameof(operatieDto));
            }

            var operatie = new Operatie
            {
                Denumire = operatieDto.Denumire,
                DetaliuComanda = operatieDto.DetaliuComanda,
                TimpExecutie = operatieDto.TimpExecutie
            };

            operatieRepository.Add(operatie);
            unitOfWork.Commit();
        }

        public void Delete(OperatieDto operatieDto)
        {
            if (operatieDto == null)
            {
                throw new ArgumentNullException(nameof(operatieDto));
            }

            var operatie = new Operatie
            {
                Denumire = operatieDto.Denumire,
                DetaliuComanda = operatieDto.DetaliuComanda,
                TimpExecutie = operatieDto.TimpExecutie
            };

            operatieRepository.Delete(operatie);
            unitOfWork.Commit();
        }

        public OperatieDto FindById(int operatieId)
        {
            if (operatieId < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(operatieId));
            }

            var operatie = operatieRepository.Query(m => m.Id == operatieId)
                                            .FirstOrDefault();

            if (operatie == null)
            {
                return null;
            }

            var operatieDto = new OperatieDto
            {
                Denumire = operatie.Denumire,
                DetaliuComanda = operatie.DetaliuComanda,
                TimpExecutie = operatie.TimpExecutie
            };

            return operatieDto;
        }

        public void Update(OperatieDto operatieDto)
        {
            if (operatieDto == null)
            {
                throw new ArgumentNullException(nameof(operatieDto));
            }

            var operatie = operatieRepository.Get(o => o.Id == operatieDto.Id).FirstOrDefault();

            operatie.Denumire = operatieDto.Denumire ?? operatie.Denumire;
            operatie.DetaliuComanda = operatieDto.DetaliuComanda ?? operatie.DetaliuComanda;
            operatie.TimpExecutie = operatieDto.TimpExecutie == default(decimal) ? operatie.TimpExecutie : operatieDto.TimpExecutie;

            unitOfWork.Commit();
        }
    }
}
