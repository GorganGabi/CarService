using ModelDesignFirst_L1;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Service
{
    public class MecanicDto
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }

        public virtual DetaliuComanda DetaliuComanda { get; set; }
    }
}
