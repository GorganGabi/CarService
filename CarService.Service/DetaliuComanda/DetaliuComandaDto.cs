using ModelDesignFirst_L1;
using System.Collections.Generic;

namespace CarService.Service
{
    public class DetaliuComandaDto
    {
        public int Id { get; set; }

        public virtual ComandaDto Comanda { get; set; }

        public virtual ICollection<MecanicDto> Mecanici { get; set; }

        public virtual ICollection<OperatieDto> Operaties { get; set; }

        public virtual ICollection<MaterialDto> Materials { get; set; }

        public virtual ICollection<ImagineDto> Imagines { get; set; }
    }
}
