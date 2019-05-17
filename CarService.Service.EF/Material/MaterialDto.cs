namespace CarService.Service.EF
{
    public class MaterialDto
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public decimal Cantitate { get; set; }
        public decimal Pret { get; set; }
        public System.DateTime DataAprovizionare { get; set; }

        public virtual DetaliuComandaDto DetaliuComanda { get; set; }
    }
}
