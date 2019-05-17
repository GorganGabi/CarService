namespace CarService.Service.EF
{
    public interface IMecanicService
    {
        void CreateNew(MecanicDto mecanicDto);
        MecanicDto FindById(int mecanicId);
        void Update(MecanicDto mecanicDto);
        void Delete(int mecanicId);
    }
}
