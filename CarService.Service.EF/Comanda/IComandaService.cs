namespace CarService.Service.EF
{
    public interface IComandaService 
    {
        void CreateNew(ComandaDto comandaDto);
        ComandaDto FindById(int comandaId);
        void Update(ComandaDto comandaDto);
        void Delete(int comandaId);
    }
}
