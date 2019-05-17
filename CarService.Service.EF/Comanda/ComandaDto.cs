namespace CarService.Service.EF
{
    public class ComandaDto
    {
        public int Id { get; set; }
        public int StareComanda { get; set; }
        public string DataSystem { get; set; }
        public System.DateTime DataProgramare { get; set; }
        public System.DateTime DataFinalizare { get; set; }
        public int KmBord { get; set; }
        public string Descriere { get; set; }
        public decimal ValoarePise { get; set; }

        public virtual ClientDto Client { get; set; }
        public virtual AutoDto Auto { get; set; }
        public virtual DetaliuComandaDto DetaliuComanda { get; set; }
    }
}
