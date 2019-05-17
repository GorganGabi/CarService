namespace CarService.Service.EF
{
    public class MecanicDto
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }

        public virtual DetaliuComandaDto DetaliuComanda { get; set; }
    }
}
