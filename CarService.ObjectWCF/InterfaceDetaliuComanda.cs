using CarService.Service.EF;
using System.ServiceModel;

namespace CarService.ObjectWCF
{
    [ServiceContract]
    interface InterfaceDetaliuComanda
    {
        [OperationContract]
        void CreateNewDetaliuComanda(DetaliuComandaDto detaliuComandaDto);

        [OperationContract]
        DetaliuComandaDto FindByIdDetaliuComanda(int detaliuComandaId);

        [OperationContract]
        void UpdateDetaliuComanda(DetaliuComandaDto detaliuComandaDto);

        [OperationContract]
        void DeleteDetaliuComanda(int detaliuComandaId);
    }
}
