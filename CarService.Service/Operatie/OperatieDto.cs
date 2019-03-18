using ModelDesignFirst_L1;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Service
{
    public class OperatieDto
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public decimal TimpExecutie { get; set; }

        public virtual DetaliuComanda DetaliuComanda { get; set; }
    }
}
