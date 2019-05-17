namespace CarService.Service.EF
{
    public interface IClientService
    {
        void CreateNew(ClientDto clientDto);
        ClientDto FindById(int clientId);
        void Update(ClientDto clientDto);
        void Delete(int clientId);
        ClientDto GetCars(int clientId);
    }
}
