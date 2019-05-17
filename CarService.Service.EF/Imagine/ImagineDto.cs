namespace CarService.Service.EF
{
    public class ImagineDto
    {
        public int Id { get; set; }
        public string Titlu { get; set; }
        public string Descriere { get; set; }
        public System.DateTime Data { get; set; }
        public byte[] Foto { get; set; }

        public virtual DetaliuComandaDto DetaliuComanda { get; set; }
    }
}
