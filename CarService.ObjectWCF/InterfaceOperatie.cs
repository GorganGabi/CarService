using CarService.Service.EF;
using System.ServiceModel;

namespace CarService.ObjectWCF
{
    [ServiceContract]
    interface InterfaceOperatie
    {
        [OperationContract]
        void CreateNewOperatie(OperatieDto operatieDto);

        [OperationContract]
        OperatieDto FindByIdOperatie(int operatieId);

        [OperationContract]
        void UpdateOperatie(OperatieDto operatieDto);

        [OperationContract]
        void DeleteOperatie(int operatieId);
    }
}
