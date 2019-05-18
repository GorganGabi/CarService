using CarService.Service.EF;
using System.ServiceModel;

namespace CarService.ObjectWCF
{
    [ServiceContract]
    interface InterfaceComanda
    {
        [OperationContract]
        void CreateNewComanda(ComandaDto comandaDto);

        [OperationContract]
        ComandaDto FindByIdComanda(int comandaId);

        [OperationContract]
        void UpdateComanda(ComandaDto comandaDto);

        [OperationContract]
        void DeleteComanda(int comandaId);
    }
}
