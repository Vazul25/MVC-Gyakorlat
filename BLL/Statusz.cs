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
    
    public partial class Statusz
    {
        public Statusz()
        {
            this.Megrendeles = new HashSet<Megrendeles>();
            this.MegrendelesTetel = new HashSet<MegrendelesTetel>();
        }
    
        public int ID { get; set; }
        public string Nev { get; set; }
    
        public virtual ICollection<Megrendeles> Megrendeles { get; set; }
        public virtual ICollection<MegrendelesTetel> MegrendelesTetel { get; set; }
    }
}