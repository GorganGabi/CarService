namespace CarService.Service.EF
{
    public interface IAutoService
    {
        void CreateNew(AutoDto autoDto);
        AutoDto FindById(int autoId);
        void Update(AutoDto autoDto);
        void Delete(int autoId);
    }
}
