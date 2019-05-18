using CarService.Service.EF;
using System.ServiceModel;

namespace CarService.ObjectWCF
{
    [ServiceContract]
    interface InterfaceMaterial
    {
        [OperationContract]
        void CreateNewMaterial(MaterialDto materialDto);

        [OperationContract]
        MaterialDto FindByIdMaterial(int materialId);

        [OperationContract]
        void UpdateMaterial(MaterialDto materialDto);

        [OperationContract]
        void DeleteMaterial(int materialId);
    }
}
