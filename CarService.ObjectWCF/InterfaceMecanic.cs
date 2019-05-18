using CarService.Service.EF;
using System.ServiceModel;

namespace CarService.ObjectWCF
{
    [ServiceContract]
    interface InterfaceMecanic
    {
        [OperationContract]
        void CreateNewMecanic(MecanicDto mecanicDto);

        [OperationContract]
        MecanicDto FindByIdMecanic(int mecanicId);

        [OperationContract]
        void UpdateMecanic(MecanicDto mecanicDto);

        [OperationContract]
        void DeleteMecanic(int mecanicId);
    }
}
