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
    
    public partial class AFA
    {
        public AFA()
        {
            this.Termek = new HashSet<Termek>();
        }
    
        public int ID { get; set; }
        public Nullable<int> Kulcs { get; set; }
    
        public virtual ICollection<Termek> Termek { get; set; }
    }
}