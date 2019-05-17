namespace CarService.Service.EF
{
    public interface IOperatieService
    {
        void CreateNew(OperatieDto operatieDto);
        OperatieDto FindById(int operatieId);
        void Update(OperatieDto operatieDto);
        void Delete(int operatieId);
    }
}
