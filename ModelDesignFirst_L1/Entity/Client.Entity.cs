using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDesignFirst_L1
{
    public partial class Client : IEntity
    {
        public int Auto_Id { get; set; }

        public int Comanda_Id { get; set; }
    }
}
