using CarService.Service.EF;
using System.ServiceModel;

namespace CarService.ObjectWCF
{
    [ServiceContract]
    interface InterfaceImagine
    {
        [OperationContract]
        void CreateNewImagine(ImagineDto imagineDto);

        [OperationContract]
        ImagineDto FindByIdImagine(int imagineId);

        [OperationContract]
        void UpdateImagine(ImagineDto imagineDto);

        [OperationContract]
        void DeleteImagine(int imagineId);
    }
}
