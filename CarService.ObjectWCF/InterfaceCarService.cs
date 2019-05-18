using System.ServiceModel;

namespace CarService.ObjectWCF
{
    [ServiceContract]
    interface InterfaceCarService : InterfaceAuto, InterfaceClient, InterfaceComanda, InterfaceDetaliuComanda, InterfaceImagine, InterfaceMaterial, InterfaceMecanic, InterfaceOperatie, InterfaceSasiu
    {
    }
}
