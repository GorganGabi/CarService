using ModelDesignFirst_L1;

namespace CarService.Service
{
    public class OperatieDto
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public decimal TimpExecutie { get; set; }

        public virtual DetaliuComanda DetaliuComanda { get; set; }
    }
}
