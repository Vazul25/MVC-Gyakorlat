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
    
    public partial class Vevo
    {
        public Vevo()
        {
            this.Telephely = new HashSet<Telephely>();
        }
    
        public int ID { get; set; }
        public string Nev { get; set; }
        public string Szamlaszam { get; set; }
        public string Login { get; set; }
        public string Jelszo { get; set; }
        public string Email { get; set; }
        public Nullable<int> KozpontiTelephelyID { get; set; }
    
        public virtual ICollection<Telephely> Telephely { get; set; }
        public virtual Telephely KozpontiTelephely { get; set; }
    }
}
