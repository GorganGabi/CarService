using ModelDesignFirst_L1;

namespace CarService.Service
{
    public class AutoDto
    {
        public int Id { get; set; }
        public string NumarAuto { get; set; }
        public string SerieSasiu { get; set; }

        public SasiuDto Sasiu { get; set; }
        public ComandaDto Comanda { get; set; }
        public ClientDto Client { get; set; }
    }
}
