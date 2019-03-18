using ModelDesignFirst_L1;
using System;
using System.Collections.Generic;
using System.Text;

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
