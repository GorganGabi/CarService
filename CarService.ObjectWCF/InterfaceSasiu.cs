using CarService.Service.EF;
using System.ServiceModel;

namespace CarService.ObjectWCF
{
    [ServiceContract]
    interface InterfaceSasiu
    {
        [OperationContract]
        void CreateNewSasiu(SasiuDto sasiuDto);

        [OperationContract]
        SasiuDto FindByIdSasiu(int sasiuId);

        [OperationContract]
        void UpdateSasiu(SasiuDto sasiuDto);

        [OperationContract]
        void DeleteSasiu(int sasiuId);
    }
}
