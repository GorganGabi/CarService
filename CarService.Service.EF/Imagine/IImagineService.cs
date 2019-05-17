namespace CarService.Service.EF
{
    public interface IImagineService
    {
        void CreateNew(ImagineDto imagineDto);
        ImagineDto FindById(int imagineId);
        void Update(ImagineDto imagineDto);
        void Delete(int imagineId);
    }
}
