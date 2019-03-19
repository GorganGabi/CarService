using ModelDesignFirst_L1;

namespace CarService.Service
{
    public class MecanicDto
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }

        public virtual DetaliuComanda DetaliuComanda { get; set; }
    }
}
