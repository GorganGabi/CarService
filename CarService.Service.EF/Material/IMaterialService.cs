namespace CarService.Service.EF
{
    public interface IMaterialService
    {
        void CreateNew(MaterialDto materialDto);
        MaterialDto FindById(int materialId);
        void Update(MaterialDto materialDto);
        void Delete(int materialId);
    }
}
