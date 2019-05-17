namespace CarService.Service.EF
{
    public interface ISasiuService
    {
        void CreateNew(SasiuDto sasiuDto);
        SasiuDto FindById(int sasiuId);
        void Update(SasiuDto sasiuDto);
        void Delete(int sasiuId);
    }
}
