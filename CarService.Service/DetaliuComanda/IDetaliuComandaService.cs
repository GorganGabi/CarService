namespace CarService.Service
{
    public interface IDetaliuComandaService
    {
        void CreateNew(DetaliuComandaDto detaliuComandaDto);
        DetaliuComandaDto FindById(int detaliuComandaId);
        void Update(DetaliuComandaDto detaliuComandaDto);
        void Delete(int detaliuComandaId);
    }
}
