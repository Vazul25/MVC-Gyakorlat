using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public static class VevoManager
    {
        public static List<string> Search(string nev)
        {
            using (CRMEntities oc = new CRMEntities())
            {
                return (from v in oc.Vevo
                        where v.Nev.Contains(nev)
                        select v.Nev).Distinct().ToList();
            }
        }
    }
}
