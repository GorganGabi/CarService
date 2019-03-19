using ModelDesignFirst_L1;

namespace CarService.Service
{
    public class SasiuDto
    {
        public int Id { get; set; }
        public string CodSasiu { get; set; }
        public string Denumire { get; set; }

        public virtual Auto Auto { get; set; }
    }
}
