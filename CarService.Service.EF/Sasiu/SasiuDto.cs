namespace CarService.Service.EF
{
    public class SasiuDto
    {
        public int Id { get; set; }
        public string CodSasiu { get; set; }
        public string Denumire { get; set; }

        public virtual AutoDto Auto { get; set; }
    }
}
