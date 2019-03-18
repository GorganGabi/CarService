using ModelDesignFirst_L1;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Service
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

        public virtual Comanda Comanda { get; set; }
        public virtual Auto Auto { get; set; }
    }
}
