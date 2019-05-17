using System.Collections.Generic;

namespace CarService.Service.EF
{
    public class ClientDto
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Adresa { get; set; }
        public string Localitate { get; set; }
        public string Judet { get; set; }
        public decimal Telefon { get; set; }
        public string Email { get; set; }

        public virtual ComandaDto Comanda { get; set; }
        public virtual ICollection<AutoDto> Auto { get; set; }
    }
}
