//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BLL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kategoria
    {
        public Kategoria()
        {
            this.AlKategoria = new HashSet<Kategoria>();
            this.Termek = new HashSet<Termek>();
        }
    
        public int ID { get; set; }
        public string Nev { get; set; }
        public Nullable<int> SzuloKategoriaID { get; set; }
    
        public virtual ICollection<Kategoria> AlKategoria { get; set; }
        public virtual Kategoria SzuloKategoria { get; set; }
        public virtual ICollection<Termek> Termek { get; set; }
    }
}
