namespace CarService.Service.EF
{
    public class OperatieDto
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public decimal TimpExecutie { get; set; }

        public virtual DetaliuComandaDto DetaliuComanda { get; set; }
    }
}
