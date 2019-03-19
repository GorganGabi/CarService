using ModelDesignFirst_L1;

namespace CarService.Service
{
    public class ImagineDto
    {
        public int Id { get; set; }
        public string Titlu { get; set; }
        public string Descriere { get; set; }
        public System.DateTime Data { get; set; }
        public byte[] Foto { get; set; }

        public virtual DetaliuComanda DetaliuComanda { get; set; }
    }
}
