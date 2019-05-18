using CarService.Service.EF;
using System.ServiceModel;

namespace CarService.ObjectWCF
{
    [ServiceContract]
    interface InterfaceAuto
    {
        [OperationContract]
        void CreateNewAuto(AutoDto autoDto);

        [OperationContract]
        AutoDto FindByIdAuto(int autoId);

        [OperationContract]
        void UpdateAuto(AutoDto autoDto);

        [OperationContract]
        void DeleteAuto(int autoId);
    }
}
