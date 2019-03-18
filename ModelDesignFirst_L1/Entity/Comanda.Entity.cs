using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDesignFirst_L1
{
    public partial class Comanda : IEntity
    {
        public int DetaliuComanda_Id { get; set; }

        public int Client_Id { get; set; }

        public int Auto_Id { get; set; }
    }
}
