using ModelDesignFirst_L1;

namespace CarService.Service
{
    public class AutoDto
    {
        public int Id { get; set; }
        public string NumarAuto { get; set; }
        public string SerieSasiu { get; set; }

        public Sasiu Sasiu { get; set; }
        public Comanda Comanda { get; set; }
        public Client Client { get; set; }
    }
}
