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
    
    public partial class Megrendeles
    {
        public Megrendeles()
        {
            this.MegrendelesTetel = new HashSet<MegrendelesTetel>();
        }
    
        public int ID { get; set; }
        public Nullable<System.DateTime> Datum { get; set; }
        public Nullable<System.DateTime> Hatarido { get; set; }
        public Nullable<int> TelephelyID { get; set; }
        public Nullable<int> StatuszID { get; set; }
        public Nullable<int> FizetesModID { get; set; }
    
        public virtual FizetesMod FizetesMod { get; set; }
        public virtual ICollection<MegrendelesTetel> MegrendelesTetel { get; set; }
        public virtual Statusz Statusz { get; set; }
        public virtual Telephely Telephely { get; set; }
    }
}
