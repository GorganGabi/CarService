using ModelDesignFirst_L1;
using System.Collections.Generic;

namespace CarService.Service
{
    public class DetaliuComandaDto
    {
        public int Id { get; set; }

        public virtual Comanda Comanda { get; set; }

        public virtual ICollection<Mecanic> Mecanici { get; set; }

        public virtual ICollection<Operatie> Operaties { get; set; }

        public virtual ICollection<Material> Materials { get; set; }

        public virtual ICollection<Imagine> Imagines { get; set; }
    }
}
