namespace CarService.Service
{
    public interface IAutoService
    {
        void CreateNew(AutoDto auto);
        AutoDto FindById(int autoId);
        void Update(AutoDto autoDto);
        void Delete(AutoDto autoDto);
    }
}
