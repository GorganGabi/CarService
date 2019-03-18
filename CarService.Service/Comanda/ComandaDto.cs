using ModelDesignFirst_L1;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Service
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

        public virtual Client Client { get; set; }
        public virtual Auto Auto { get; set; }
        public virtual DetaliuComanda DetaliuComanda { get; set; }
    }
}
