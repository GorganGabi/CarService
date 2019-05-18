using CarService.Service.EF;
using System.ServiceModel;

namespace CarService.ObjectWCF
{
    [ServiceContract]
    interface InterfaceClient
    {
        [OperationContract]
        void CreateNewClient(ClientDto clientDto);

        [OperationContract]
        ClientDto FindByIdClient(int clientId);

        [OperationContract]
        void UpdateClient(ClientDto clientDto);

        [OperationContract]
        void DeleteClient(int clientId);

        [OperationContract]
        ClientDto GetCarsClient(int clientId);
    }
}
