//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelDesignFirst_L1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comanda
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
